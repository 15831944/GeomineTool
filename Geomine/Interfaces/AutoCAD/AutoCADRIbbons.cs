using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;

namespace Geomine.Interfaces.AutoCAD
{
   public class AutoCADRibbons : IExtensionApplication
    {
        public void Initialize()
        {
            App.Main();
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }
    }
}
