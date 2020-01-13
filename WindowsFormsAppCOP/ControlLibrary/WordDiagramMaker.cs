using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace ControlLibrary
{
    public partial class WordDiagramMaker : Component
    {
        public WordDiagramMaker()
        {
            InitializeComponent();
        }

        public WordDiagramMaker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <typeparam name="T"></typeparam>
        /// <param name="objects">Список объектов.</param>
        /// <param name="name">Название свойства содержащего имя объекта.</param>
        /// <param name="count">Название свойства содержащего количество объектов.</param>
        /// <param name="path">Строка вида @"D:\path\to\diagram.docx".</param>
        public void CreateDiagram<T>(List<T> objects, string name, string count, string path)
        {
            DocX doc = DocX.Create(path);

            BarChart barChart = new BarChart();
            barChart.AddLegend(ChartLegendPosition.Top, false);

            Series series = new Series("Products");
            series.Bind(objects, name, count);
            barChart.AddSeries(series);

            doc.InsertChart(barChart);

            doc.Save();
        }

    }
}
