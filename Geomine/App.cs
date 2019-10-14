using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Geomine.Interfaces;

namespace Geomine
{
    public class App
    {
       static DebugInterface appInterface = new DebugInterface();


        static void Main()
        {

            Application.EnableVisualStyles();
            Application.Run(new ProjectManager());


        }



    }
}