using WinForms_Demo.Demos;

namespace WinForms_Demo;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();

        // use this to quickly launch a test Form while developing
        Application.Run(new Main());
    }
}
