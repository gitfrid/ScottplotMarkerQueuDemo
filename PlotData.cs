
namespace WinForms_Demo;

public class PlotData
{
    private readonly PlotQueue plotDataQueue;
    
      // stores twou double  values to plot two signals
    readonly double[] plotLinesValues = new double[2];

    public double DataValues1
    {
        get => plotLinesValues[0];
        set => plotLinesValues[0] = value;
    }

    public double DataValues2
    {
        get => plotLinesValues[1];
        set => plotLinesValues[1] = value;
    }
    
    public PlotData()
    {
        plotDataQueue = new PlotQueue();
        // init array with 0s
        Array.Fill(plotLinesValues, 0);
    }

    public void ResetCounter()
    {
        Array.Fill(plotLinesValues, 0);
    }
    public void ClearPlotQueue()
    {
        PlotDataQueue.ClearQueue();
    }

    // public prop to access the queue
    public PlotQueue PlotDataQueue         
    {
        
        get => plotDataQueue; 
    }

    //writes two double values into the ploter queue, with every EnqueueList
    public void WriteToQueue()
    {
        // list with 2 double values to Enqueue, read out by Dequeue on the plotform
        // for example to plot two lines on a chart, or plot something else 
        List<double> values = [];
        for (int i = 0; i < 2; i++)
        {
            values.Add(plotLinesValues[i]);
        }        
        PlotDataQueue.EnqueueList(values);
    }
    
}
