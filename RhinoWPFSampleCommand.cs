using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace RhinoWPFSample
{
    [Guid("8d37fcd7-3a80-4eb4-8db0-f5ca1c828519")]
    public class RhinoWPFSampleCommand : Command
    {
        public RhinoWPFSampleCommand()
        {
            // Rhino only creates one instance of each command class defined in a
            // plug-in, so it is safe to store a refence in a static property.
            Instance = this;
        }

        ///<summary>The only instance of this command.</summary>
        public static RhinoWPFSampleCommand Instance
        {
            get; private set;
        }

        ///<returns>The command name as it appears on the Rhino command line.</returns>
        public override string EnglishName
        {
            get { return "RhinoWPFSampleCommand"; }
        }

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            

            var settings = new Settings(doc);
            
            var s = new SampleMainLine();

            s.Run();


            return Result.Success;
        }
    }
}
