using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace WindowsFormsAppCOP
{
    public partial class FormTree : Form
    {
        public new IUnityContainer Container { get; set; }

        public FormTree()
        {
            InitializeComponent();
            List<Organization> list = new List<Organization>();
            list.Add(new Organization("стол", "Русь"));
            list.Add(new Organization("стул", "Русь"));
            list.Add(new Organization("шкаф", "Агропродукт"));
            list.Add(new Organization("шкаф", "Агропродукт"));

            controlTreeView1.SetList(list, (x) => x.TypeName, (y) => y.Name);

        }
    }
}
