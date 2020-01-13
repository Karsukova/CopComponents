using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlLibrary;

namespace WindowsFormsAppCOP
{
    public partial class FormMain : Form
    {
        List<DeliveryProduct> list;
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Cop = new FormCOP();
            Cop.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Cop = new FormTree();
            Cop.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Cop = new FormTelephone();
            Cop.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list = new List<DeliveryProduct>();
            list.Add(new DeliveryProduct { Name = "ООО Деловая Русь", Category = "Мягкая", Count = 5 });
            list.Add(new DeliveryProduct { Name = "ООО Концепт", Category = "Мягкая", Count = 10 });
            list.Add(new DeliveryProduct { Name = "ООО Альтаир", Category = "Корпусная", Count = 7 });
            //WordDiagramMaker.CreateDiagram(list, "Name", "Count", @"C:\Users\Дарья\Music\diagram.docx");
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
           var list = new List<CompanyInfo>();
            list.Add(new CompanyInfo { Name = "ООО Деловая Русь", TelNumber = "+79996637774"});
            list.Add(new CompanyInfo { Name = "ООО Концепт", TelNumber = "+79377778889"});
            list.Add(new CompanyInfo { Name = "ООО Альтаир", TelNumber = "+79687773345" });
             ExcelComponent.CreateExcelReport(list, @"C:\Users\Дарья\Music\NewExcelFile.xls", false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var list = new List<DeliveryProduct>();
            list.Add(new DeliveryProduct { Name = "ООО Деловая Русь", Category = "Мягкая", Count = 5 });
            list.Add(new DeliveryProduct { Name = "ООО Концепт", Category = "Мягкая", Count = 10 });
            list.Add(new DeliveryProduct { Name = "ООО Альтаир", Category = "Корпусная", Count = 7 });
            //SerializationComponent.SaveData(list, @"C:\Users\Дарья\Music\data.json");
        }
    }
}
