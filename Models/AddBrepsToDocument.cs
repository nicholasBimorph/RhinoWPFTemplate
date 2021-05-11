using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino;
using Rhino.Geometry;



namespace RhinoWPFSample
{
    internal class AddBrepsToDocument
    {
        
        internal AddBrepsToDocument()
        {

        }
        public void Execute()
        {
            var brep = Brep.CreateBaseballSphere(Point3d.Origin, 1000, 0.001);

            Settings.RhinoDocument.Objects.AddBrep(brep);

            Settings.RhinoDocument.Views.Redraw();
        }
    }
}
