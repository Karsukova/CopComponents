using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

using System.Threading.Tasks;

namespace WindowsFormsAppCOP
{
    [DataContract]
    public class DeliveryProduct
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Category { get; set; }


        [DataMember]
        public int Count { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
