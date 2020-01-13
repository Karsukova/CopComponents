using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ControlLibrary
{
    public partial class ControlTelNum : UserControl
    {
        public string Text
        {
            get
            {
                if (textBoxNum.BackColor == Color.Red)
                    return null;
                return textBoxNum.Text;
            }
            set
            {
                textBoxNum.Text = value;
            }
        }
        public ControlTelNum()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(textBoxNum.Text, @"(89|\+79)\d{9}");
            ToolTip toolTip = new ToolTip();

            if (textBoxNum.Text != "" && match.Success)
            {
                textBoxNum.BackColor = Color.Green;
            }
            else
            {
                textBoxNum.BackColor = Color.Red;
                toolTip.Show("Формат номера телефона: +79997233907 или 89997233907", textBoxNum);
            }
        }


    }
}
