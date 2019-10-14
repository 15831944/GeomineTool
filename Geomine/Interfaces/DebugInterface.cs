using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomine.Interfaces
{
    class DebugInterface
    {
        private Debug.GraphicForm mainForm = new Debug.GraphicForm();

        public DebugInterface()
        {

            mainForm.Show();

        }

        public void ShowForm(System.Windows.Forms.Form formInstance )
        {

            formInstance.Show();

        }

    }
}
