using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCOP
{
    public class Organization
    {
        public string TypeName { get; set; }
        public string Name { get; set; }

        public Organization(string name, string type)
        {
            Name = name;
            TypeName = type;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
