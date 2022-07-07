using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharp_Application
{
     public class Person
    {
        public string name { get; set; }
        public string city { get; set; }
        public int age { get; set; }

        public Person getdata()
        {
            Person obj = new Person();
            Console.WriteLine("Enter the Name : ");
            obj.name = Console.ReadLine();
            Console.WriteLine("Enter the Age : ");
            obj.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the City : ");
            obj.city = Console.ReadLine();
            return obj;

        }
        public void XmlSerialize()  // convert object information into xml format for transferring over the network
        {
            Person bs = getdata();
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            TextWriter txtWriter = new StreamWriter(@"C:\UNext\Serialization_Person.xml");
            xs.Serialize(txtWriter, bs);
            txtWriter.Close();

        }

        public void XmlDeSerialize()
        {
            Person person = new Person();
            XmlSerializer xmlobj = new XmlSerializer(typeof(Person));
            StreamReader readerobj = new StreamReader(@"C:\UNext\Serialization_Person.xml");
            person = (Person)xmlobj.Deserialize(readerobj);

            Console.WriteLine("\nThe Values are as follows : ");
            Console.WriteLine("Name : " + person.name);
            Console.WriteLine("Age: " + person.age);
            Console.WriteLine("City : " + person.city);

        }

        public void JsonSerialize()
        {
            Person person_obj = getdata();
            string jsonString = JsonSerializer.Serialize(person_obj);

            var dsr_obj = JsonSerializer.Deserialize<Person>(jsonString);
            Console.WriteLine("\n\nThe Name of the person is : " + dsr_obj.name);
            Console.WriteLine("The Age of the person is : " + dsr_obj.age);
            Console.WriteLine("The City of the person is : " + dsr_obj.city);
        }

    }



   
