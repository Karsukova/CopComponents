using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Threading.Tasks;
using IronXL;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.Reflection;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class MyExcelReport : Component
    {
        private char[] columns = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        public string FieldType { get; set; }

        public MyExcelReport()
        {
            InitializeComponent();
        }

        public MyExcelReport(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public void CreateExcelReport<T>(List<T> list, string path, bool Revert)
        {
            WorkBook xlsWorkbook = WorkBook.Create(ExcelFileFormat.XLS);
            WorkSheet xlsSheet = xlsWorkbook.CreateWorkSheet("new_sheet");
            PropertyInfo[] properties = null;
            int row = 1;
            if (list != null)
            {
                properties = list[0].GetType().GetProperties();
            }
            if (properties.Length > 10)
            {
                MessageBox.Show("Не больше 10 свойств");
                return;
            }
            int j = 0;
            for (int i = 0; i < properties.Length; i++)
            {
                if (Revert)
                {
                    xlsSheet[columns[i] + "" + row].Value = properties[i].Name;
                }
                else
                {
                    xlsSheet[columns[j] + "" + row].Value = properties[i].Name;
                }
                row++;
            }
            string cell = "";
            if (Revert)
            {
                foreach (var value in list)
                {
                    j = 0;
                    for (int i = 0; i < properties.Length; i++, j++)
                    {
                        cell += columns[j];
                        cell += "" + row;
                        xlsSheet[cell].Value = properties[i].GetValue(value).ToString();
                        cell = "";
                    }
                    row++;
                }
            }
            else
            {
                foreach (var value in list)
                {
                    row = 1;
                    j++;
                    for (int i = 0; i < properties.Length; i++)
                    {
                        cell += columns[j];
                        cell += "" + row;
                        xlsSheet[cell].Value = properties[i].GetValue(value).ToString();
                        row++;
                        cell = "";
                    }
                }
            }
            xlsWorkbook.SaveAs(path + "\\NewExcelFile.xls");
        }
    }
}
