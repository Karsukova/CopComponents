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
    public partial class FormCOP : Form
    {
        public new IUnityContainer Container { get; set; }

        public FormCOP()
        {
            InitializeComponent();
            controlListBoxSelected.LoadEnumeration(typeof(Mebel));
        }
        private void controlComboBoxSelected_ComboBoxSelectedElementChange(object sender,
EventArgs e)
        {
            MessageBox.Show(controlListBoxSelected.SelectedText);
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            controlListBoxSelected.SelectedIndex = 0;
        }
    }
}
