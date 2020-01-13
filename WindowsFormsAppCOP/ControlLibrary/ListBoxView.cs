using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ControlLibrary
{
    public partial class ListBoxView : UserControl
    {
        public ListBox.ObjectCollection Items => listBox.Items;
        public string Pattern { get; set; }

        public void Add(object obj)
        {
            listBox.Items.Add(MakeString(obj));
        }

        public void AddRange(IEnumerable<object> objects)
        {
            listBox.Items.AddRange(MakeStrings(objects));
        }

        public ListBoxView()
        {
            InitializeComponent();
        }

        private string[] MakeStrings(IEnumerable<object> objects)
        {
            var result = new List<string>();
            result.Add(GetPattern());
            foreach (var i in objects)
            {
                result.Add(MakeString(i));
                
            }
            
            return result.ToArray();
        }
        public string GetPattern()
        {
            var result = "";
            var fieldsNames = Regex.Matches(Pattern, @"{\w+}")
               .Cast<Match>()
               .Select(m => m.Value)
               .ToArray();
            string[] infos = new string[20];
            int k = 0;
            foreach (var x in fieldsNames)
            {
                var t = x.Trim(new Char[] { '{', '}' });
                infos[k] = t;
                k++;
                result += t + " ";
            }
            return result;
        }

        private string MakeString(Object obj)
        {
            var fieldsNames = Regex.Matches(Pattern, @"{\w+}")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();
            string[] infos = new string[20];
            int k = 0;
            foreach (var x in fieldsNames)
            {
                var t = x.Trim(new Char[] { '{', '}'});
                infos[k] = t;
                k++;
            }
            BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic |
BindingFlags.Static | BindingFlags.Instance |
BindingFlags.DeclaredOnly;

            var my_type = obj.GetType();
            var fields = my_type.GetFields(flags);
           
            var result = "";
             k = 0;
            var currFields = new List<String>();
            var id_field = my_type.GetField("id");
            foreach (var _field in my_type.GetFields(flags))
            {
                if (k == 0)
                {
                    k++;
                    id_field = _field;
                }
                currFields.Add(_field.Name);
            }
            foreach (var field in my_type.GetFields(flags))
            {
                var fieldInfo = id_field;
                if (fieldInfo != null)
                {
                    result += " " + field.GetValue(obj).ToString();
                }
                else
                {
                    result += " ошибка объекта";
                }
            }
            /*foreach (var i in infos)
            {
                    var field = fields.First(x => x.Name == "<" + i + ">k_BackingField");
                    var newValue = (string)field.GetValue(obj);
                    result = result.Replace(i, newValue);
                
            }
            */

            return result;
        }
    }
}
