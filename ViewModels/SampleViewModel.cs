using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Rhino;

namespace RhinoWPFSample.ViewModels
{
    public class SampleViewModel
    {
        public IntPtr HostApplicationWindowHandle { get; }

        public ICommand AddBrepCommand { get; private set; }
        public SampleViewModel(/*IAction addBrepsToDoc*/)
        {
            this.HostApplicationWindowHandle = RhinoApp.MainWindowHandle();

            this.AddBrepCommand = new AddBrepCommand(new AddBrepsToDocument());
        }
    }
}