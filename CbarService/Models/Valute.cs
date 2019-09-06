using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CbarService.Models
{
    [Serializable]
   public class Valute
    {
        [XmlAttribute]
        public string Code { get; set; }
        public string Nominal { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public override string ToString()
        {
            return $"{Name}   --   {Value} ";
        }
    }
}
