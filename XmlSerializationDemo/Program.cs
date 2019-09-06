using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //klasin obyekti yaradilir
            User user = new User
            {
                Email = "midoriya@gmail.com",
                Id = 1,
                IsLocked = false,
                Password = "23423rd@#$s",
                UserName = "Midoriya"
            };

            ////obyekt serializasiya olunur...
            //XmlSerializer serializer = new XmlSerializer(typeof(User));
            //using(FileStream fs = new FileStream("demo.xml",FileMode.OpenOrCreate))
            //{
            //    serializer.Serialize(fs, user);
            //}

            Person person = new Person
            {
                Age = 45,
                Email = "todoroki@gmail.com",
                Id = 3,
                Name = "Todoroki"
            };
            //obyekt serializasiya olunur...
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, person);
            }

        }
    }
}
