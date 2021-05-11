using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino;

namespace RhinoWPFSample
{
    internal class Settings
    {
        public static RhinoDoc RhinoDocument { get; private set; }
        internal Settings(RhinoDoc rhinoDoc)
        {
            RhinoDocument = rhinoDoc;
        }
    }
}
