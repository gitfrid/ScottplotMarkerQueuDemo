
using WinForms_Demo.Demos;

namespace WinForms_Demo;

// This uses ScpottPlot WinForms 4.1.70
//
// Tried Version 5 Beta first, but could not find out
// how to use MaxRenderIndex = nextDataIndex or the replacement for it
// as i actually wanted to test SignalXY, which is not jet in the demos here

public partial class Main : Form
{

    private Ploter ploterSimulation;

    public Main()
    {
        InitializeComponent();
        ploterSimulation = new();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        try
        {
            // this does the main work, in this example adds two double values to plotqueue
            // the plotform then reads it from the queue and plots them in "realtime" on Diagram 
            ploterSimulation?.NextIteration();
            this.Text = $"Main Iteration: {ploterSimulation?.Iteration}";
        }
        catch (Exception ex)
        {
            string innerMessage = "";
            if (ex.InnerException != null)
                innerMessage = ex.InnerException.Message;
            MessageBox.Show(ex.Message.ToString() + "\r\n" + innerMessage);
            this.Close();
        };
    }

    private void StartMarkerButton_Click(object sender, EventArgs e)
    {
        // cerates new ploter simulation obj
        ploterSimulation = new();

        // shows the marker plotform containing the plot chart
        Form? markerQueueDemoForm = Application.OpenForms["MarkerQueueDemo"];
        markerQueueDemoForm?.Close();
        MarkerQueueDemo markQueueDemoForm = new(ploterSimulation.PlotData);
        markQueueDemoForm.Show();

        //starts the iterations(timer), which does the main work
        ploterSimulation.StopIteration = false;
        Timer.Enabled = true;
    }

    private void StartLineButton_Click(object sender, EventArgs e)
    {
        // shows the line plotform containing the plot chart
        Form? lineQueueDemoForm = Application.OpenForms["LineQueueDemo"];
        lineQueueDemoForm?.Close();
        LineQueueDemo lnQueueDemoForm = new(ploterSimulation.PlotData);
        lnQueueDemoForm.Show();

        ploterSimulation.StopIteration = false;
        Timer.Enabled = true;
    }
    private void StartSignalButton_Click(object sender, EventArgs e)
    {
        // shows the line plotform containing the plot chart
        Form? siganlQueueDemoForm = Application.OpenForms["SignalQueueDemo"];
        siganlQueueDemoForm?.Close();
        SingalQueueDemo sigQueueDemoForm = new(ploterSimulation.PlotData);
        sigQueueDemoForm.Show();

        ploterSimulation.StopIteration = false;
        Timer.Enabled = true;
    }

    private void StopButton_Click_1(object sender, EventArgs e)
    {
        ploterSimulation.StopIteration = true;
        Timer.Enabled = false;
        this.Text = $"Main Iteration:";

        Form? lineQueueDemoForm = Application.OpenForms["LineQueueDemo"];
        lineQueueDemoForm?.Close();
        Form? markerQueueDemoForm = Application.OpenForms["MarkerQueueDemo"];
        markerQueueDemoForm?.Close();
        Form? siganlQueueDemoForm = Application.OpenForms["SignalQueueDemo"];
        siganlQueueDemoForm?.Close();
    }

}
