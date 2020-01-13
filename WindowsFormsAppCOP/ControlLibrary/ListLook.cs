using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class ListLook : UserControl
    {
        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        private int _selectedIndexFIO;
        private List<String> displayData;

        /// <summary>
        /// Сохраняет поля сериализуемых объектов, которые нужно отобразить
        /// </summary>
        public void SetData(string[] fields, Object[] objects)
        {
            var res = new List<string>();
            res.Add(fields.Aggregate("", (acc, x) => acc + x + " "));
            foreach (var item in objects)
            {
                BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic |
BindingFlags.Static | BindingFlags.Instance |
BindingFlags.DeclaredOnly;
                Type t = item.GetType();
                int k = 0;
                var currFields = new List<String>();
                var id_field = t.GetField("id");
                foreach (var _field in t.GetFields(flags))
                {
                    if (k == 0)
                    {
                        k++;
                        id_field = _field;
                    }
                    currFields.Add(_field.Name);
                }
                var _res = "";
                foreach (var field in t.GetFields(flags))
                {
                    var fieldInfo = id_field;
                    if (fieldInfo != null)
                    {
                        _res += " " + field.GetValue(item).ToString();
                    }
                    else
                    {
                        _res += " ошибка объекта";
                    }
                }
                res.Add(_res);
            }
        }

        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
        public int SelectedIndex
        {
            get { return _selectedIndexFIO; }
            set
            {
                if (value > -2 && value < listBox.Items.Count)
                {
                    _selectedIndexFIO = value;
                    listBox.SelectedIndex = _selectedIndexFIO;
                }
            }
        }

        /// <summary>
        /// Текст выбранной записи
        /// </summary>
        [Category("Спецификация"), Description("Текст выбранной записи")]
        public string SelectedText
        {
            get { return listBox.SelectedItem.ToString(); }
        }

        public ListLook()
        {
            InitializeComponent();
            //     listBox.Items.Add(fields.ToString());
        }

        /// <summary>
        /// Добавление элемента в список
        /// </summary>
        /// <param name="type">тип-справочник</param>
        public void AddLine(String str)
        {
            listBox.Items.Insert(listBox.Items.Count - 1, str);
        }

        /// <summary>
        /// Заполнение списка ФИО менеджеров значениями из справочника
        /// </summary>
        /// <param name="type">тип-справочник</param>
        public void LoadEnumeration(List<string> list)
        {
            foreach (var elem in list)
            {
                listBox.Items.Add(elem.ToString());
            }
        }
    }
}
