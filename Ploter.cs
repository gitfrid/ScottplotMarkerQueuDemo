
namespace WinForms_Demo;

public class Ploter
{
    private readonly PlotData plotData = new();
    private bool stopIteration;
    private int iteration = 0;
    
    private readonly Random rnd = new();

    // fills arrays with 500_000 random doubles
    private readonly double[] data1 = ScottPlot.Generate.RandomWalk(count: 5000000, mult: 1 );
    private readonly double[] data2 = ScottPlot.Generate.RandomWalk(count: 5000000, mult: 2 );

    public int Iteration
    {
        get => iteration;
    }

    // public prop to access the queue
    public PlotData PlotData
    {
        get => plotData;
    }

    public bool StopIteration
    {
        get => stopIteration;
        set => stopIteration = value;
    }
    public Ploter()
    {
        // just another way then Randomwalk, to fill the array with doubles 
        //for (int n = 0; n < 500000; n++)
        //{
        //    data1[n] = (double)rnd.NextDouble() * rnd.Next(1, 1000);
        //    data2[n] = (double)rnd.NextDouble() * rnd.Next(1, 1000);
        //}
    }
    public void NextIteration()
    {
        if (stopIteration == true) { return; }
        
        // do your work here 

        // next iteration is called by a timer in the main form 
        // for this example it gets two random doubles with every iteration
        // and writes them into the plotqueue to plot them on a separate plotform
        plotData.DataValues1 = data1[iteration];
        plotData.DataValues2 = data2[iteration];
        iteration++;
        plotData.WriteToQueue();
    }

}
