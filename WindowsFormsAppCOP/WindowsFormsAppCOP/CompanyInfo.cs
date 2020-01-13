using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCOP
{
    public class CompanyInfo
    {
        public string Name { get; set; }

        public string TelNumber { get; set; }
        
        
        public override string ToString()
        {
            return Name;
        }
    }
}
