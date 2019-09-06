using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CbarService.Models
{
    [Serializable]
    [XmlRoot(ElementName ="ValCurs")]
   public class ValuteCur
    {
        [XmlAttribute]
        public string Date { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Description { get; set; }

        [XmlElement(ElementName ="ValType")]
        public ValuteType[] ValTypes { get; set; }

    }
}
