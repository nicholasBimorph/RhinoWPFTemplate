using Rhino;

using RhinoWPFSample.ViewModels;
using RhinoWPFSample.Views;

namespace RhinoWPFSample
{
    internal class SampleMainLine
    {
        internal SampleMainLine()
        {
           
        }
        internal void Run()
        {
            //var addBrepsToDoc = new AddBrepsToDocument();

            var viewModel = new SampleViewModel( /*addBrepsToDoc*/);

            var mainWindow = new MainWindow(viewModel);

            mainWindow.ShowDialog();
        }
    }
}