using ScottPlot;


namespace WinForms_Demo.Demos;

public partial class LineQueueDemo : Form
{
    private int nextDataIndex = 0;

    private readonly double[][] ploterData = new double[2][];

    private readonly PlotData plotData;

    public LineQueueDemo(PlotData PlotData)
    {
        InitializeComponent();
        plotData = PlotData;

        // create empty data x y arrays with length of MaxIterations add it to the plot 
        for (int i = 0; i < 2; i++)
        {
            ploterData[i] = new double[5000000]; //-> must be same length as in PlotData 
        }
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
        DataTimer.Enabled = true;
        RenderTimer.Enabled = true;
        formsPlotgl1.Plot.Render();
        //formsPlotgl1.Plot.AxisAuto(); // <- auto zoom
        //formsPlotgl1.Plot.SetAxisLimits(0, 50, -20, 20, 0, 1); // <- manual zoom
    }

    //reads two double values from ploter queue with every TryDequeueList
    private void DataTimer_Tick(object sender, EventArgs e)
    {
        if (nextDataIndex >= ploterData[0].Length)
        {
            DataTimer?.Stop();
            RenderTimer?.Stop();
            throw new OverflowException("PlotForm data array isn't long enough to accomodate new data");
        }

        // timing of enqueue in the ploter class, and dequeue here,
        // should be harmonized with each other
        // n is arbitrary, how often trying to dequeue with one timer event
        for (int n = 0; n < 2; n++)
        {
            bool success = plotData.PlotDataQueue.TryDequeueList(out List<double> values);
            if (success)
            {
                //.MaxRenderIndex = nextDataIndex;
                for (int i = 0; i < ploterData.Length; i++)
                {
                    ploterData[i][nextDataIndex] = values[i];
                    if (nextDataIndex > 1) 
                    { 
                        formsPlotgl1.Plot.AddLine(ploterData[0][nextDataIndex], ploterData[1][nextDataIndex], ploterData[0][nextDataIndex - 1], ploterData[1][nextDataIndex - 1],Color.Blue); 
                    };
                }
                nextDataIndex += 1;
            }
            else
            {
                break;
            }
        }
        Text = $"Chart iterations: ({nextDataIndex:N0} )";
    }

    private void RenderTimer_Tick(object sender, EventArgs e)
    {
        formsPlotgl1.Refresh();
    }

    private void StopButton_Click(object sender, EventArgs e)
    {
        DataTimer.Enabled = false;
        RenderTimer.Enabled = false;
    }

    private void ManZoomButton_Click(object sender, EventArgs e)
    {
        formsPlotgl1.Plot.SetAxisLimits(0, 50, -20, 20, 0, 1); // <- manual zoom
        formsPlotgl1.Plot.Render();
    }   
}
