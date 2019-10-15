using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Geomine.Interfaces;

namespace Geomine
{
    public class App
    {
       static Interface appInterface;

        [STAThreadAttribute]
        public static void Main()
        {
            string str = Assembly.GetExecutingAssembly().CodeBase;
            if (str[str.Length - 1]!= 'e') appInterface = new AutoCADInterface(); else appInterface = new DebugInterface();

            appInterface.ShowForm(new ProjectManager());



        }



    }
}