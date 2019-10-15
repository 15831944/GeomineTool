using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;


namespace Geomine.Interfaces
{
    public class AutoCADInterface : Interface
    {
        public override void ShowForm(System.Windows.Forms.Form formInstance)
        {
            Application.ShowModelessDialog(formInstance);
        }

    }

}
