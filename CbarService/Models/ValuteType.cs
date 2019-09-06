using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CbarService.Models
{
    [Serializable]
   public class ValuteType
    {
        [XmlAttribute]
        public string Type { get; set; }

        [XmlElement(ElementName ="Valute")]
        public Valute[] Valutes { get; set; }
    }
}
