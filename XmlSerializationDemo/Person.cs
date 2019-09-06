using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializationDemo
{
   public class Person
    {
        [XmlAttribute(AttributeName ="Identifier")]
        public int Id { get; set; }

        [XmlAttribute]
        public byte Age { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
