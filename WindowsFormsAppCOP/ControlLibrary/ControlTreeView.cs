using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    
        public partial class ControlTreeView : UserControl
        {
            Dictionary<string, TreeNode> types;

            public ControlTreeView()
            {
                InitializeComponent();
                types = new Dictionary<string, TreeNode>();
            }

        public void SetList<T>(List<T> mebelList, Func<T, object> getType, Func<T, object> getName)
        {
            foreach (T organization in mebelList)
            {
                string cat = getType(organization).ToString();

                if (!types.Keys.Contains(cat))
                {
                    int index = treeView.Nodes.Add(new TreeNode(cat));
                    types.Add(cat, treeView.Nodes[index]);
                }

                types[cat].Nodes.Add(new TreeNode(getName(organization).ToString()));
            }

            treeView.ExpandAll();
        }

        

    }
}
