using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geomine
{
    public partial class ProjectManager : Form
    {

        Dictionary<string, TreeNode[]> treeFolders ;
            

    public ProjectManager()
        {
            InitializeComponent();
            InitializeTreeTypes();
            treeViewInstance.Nodes.AddRange(treeFolders.First());
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ProjectManager_Load(object sender, EventArgs e)
        {

        }

        
        private void InitializeTreeTypes()
        {

            treeFolders = new Dictionary<string, TreeNode[]>();

            TreeNode[] treeNodes = new TreeNode[] { };
            //
            TreeNode graphicalData = new TreeNode("Graphical Data");
            //lines, points, meshes
            TreeNode sampleData = new TreeNode("");
            TreeNode geologicalModels = new TreeNode("");
            TreeNode blockModels = new TreeNode("");
            TreeNode engineerDesigns = new TreeNode("");

            treeFolders.Add("all", new TreeNode[] {  });

        }
    }
}
