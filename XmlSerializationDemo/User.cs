using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializationDemo
{
    [Serializable]
    public class User
    {
        [XmlElement(ElementName ="Identifier")]
        public int Id { get; set; }
        [XmlElement(ElementName = "User_Name")]
        public string UserName { get; set; }

        public string Email { get; set; }
        [XmlElement(ElementName = "Parol")]
        public string Password { get; set; }


        public bool IsLocked { get; set; }

        public override string ToString()
        {
            return $"{Id} {UserName} {Password} {IsLocked}";
        }
    }
}
