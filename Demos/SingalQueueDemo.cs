using ScottPlot;
using ScottPlot.Plottable;


namespace WinForms_Demo.Demos;

public partial class SingalQueueDemo : Form
{
    private int nextDataIndex = 0;

    private readonly double[][] ploterData = new double[2][];

    private readonly PlotData plotData;

    public SingalQueueDemo(PlotData PlotData)
    {
        InitializeComponent();
        plotData = PlotData;

        // create empty data x y arrays with length of MaxIterations add it to the plot 
        for (int i = 0; i < 2; i++)
        {
            ploterData[i] = new double[5000000]; //-> must be same length as in PlotData 
        }

        // use different colosr for both signals
        var Colors = new Color[] { Color.DarkRed, Color.DarkBlue };

        var sig1 = formsPlotgl1.Plot.AddSignal(ploterData[0], sampleRate: 1, Colors[0]);
        var sig2 = formsPlotgl1.Plot.AddSignal(ploterData[1], sampleRate: 1, Colors[1]);

        //// add a second Y axis to the plot
        //ScottPlot.AxisPanels.LeftAxis yAxis2 = new();
        //formsPlotgl1.Plot.Axes.Add(yAxis2);

        //signalPlot = formsPlotgl1.Plot.AddSignal(data);
        //formsPlotgl1.Plot.SetAxisLimits(0, 100, -2, 2);
        //formsPlotgl1.Plot.SetAxisLimits(0, data.Length, -2, 2);


        //// store the two vertical axes locally so we can reference them any time
        //YAxis1 = formsPlotgl1.Plot.YAxes[0];
        //YAxis2 = formsPlotgl1.Plot.YAxes[1];

        //// set axis
        //sig1.Axes.YAxis = YAxis1;
        //sig1.Axes.YAxis.Label.Text = "YAxis1";
        //sig1.Axes.YAxis.Label.PointColor = sig1.LineStyle.Color;

        //sig2.Axes.YAxis = YAxis2;
        //sig2.Axes.YAxis.Label.Text = "YAxis2";
        //sig2.Axes.YAxis.Label.PointColor = sig2.LineStyle.Color;
    }


    private void StartButton_Click(object sender, EventArgs e)
    {
        DataTimer.Enabled = true;
        RenderTimer.Enabled = true;
        formsPlotgl1.Plot.Render();
        formsPlotgl1.Plot.AxisAuto(); // <- auto zoom
        //formsPlotgl1.Plot.SetAxisLimits(0, 50, -20, 20, 0, 1); // <- manual zoom
        //formsPlotgl1.Plot.Clear();

    }
    private void DataTimer_Tick(object sender, EventArgs e)
    {
        if (nextDataIndex >= ploterData[0].Length)
        {
            DataTimer?.Stop();
            RenderTimer?.Stop();
            throw new OverflowException("PlotForm data array isn't long enough to accomodate new data");
        }

        // enqueue in the ploter class and timing should be adjusted with dequeue here
        // n is just a parameter how often trying to dequeue  in one timer event
        for (int n = 0; n < 2; n++)
        {
            bool success = plotData.PlotDataQueue.TryDequeueList(out List<double> values);
            if (success)
            {
                //MaxRenderIndex = nextDataIndex; 
                for (int i = 0; i < ploterData.Length; i++)
                {
                    ploterData[i][nextDataIndex] = values[i];
                }
                nextDataIndex += 1;
                formsPlotgl1.Plot.SetAxisLimits(0, nextDataIndex + 1, -2, 2); //<- right boarder
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

    private void ScaleButton_Click(object sender, EventArgs e)
    {
        //scale the  plot
        formsPlotgl1.Plot.SetAxisLimits(0, nextDataIndex + 1, -2, 2); //<- scale right boarder
        formsPlotgl1.Plot.AxisAutoY(); // <- scale y size
        //formsPlotgl1.Plot.AxisAuto();        
        formsPlotgl1.Refresh();
    }

}
