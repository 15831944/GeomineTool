using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geomine.Interfaces
{
    public class DebugInterface : Interface
    {
        private Debug.GraphicForm mainForm = new Debug.GraphicForm();

        public DebugInterface()
        {

            mainForm.Show();

        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public override void ShowForm(System.Windows.Forms.Form formInstance )
        {

            Application.EnableVisualStyles();
            Application.Run(formInstance);

        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }
    }
}
