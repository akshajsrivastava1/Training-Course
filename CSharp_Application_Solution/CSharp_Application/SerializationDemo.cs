using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization; // Imported by selecting XmlSerializer and then ctrl + .

namespace CSharp_Application
{
     public class Employee
    {
        public int Id = 1;
        public string name = "John Smith";
        public string subject = "Physics";

    }
    internal class SerializationDemo
    {
        public class WeatherForecast
        {
            public DateTimeOffset Date { get; set; }

            public int TemperatureCelsius { get; set; }

            public string Summary { get; set; }
        }
        public void JsonSerialize()
        {
            var WeatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"

            };
            string jsonString = JsonSerializer.Serialize(WeatherForecast);

            var obj = JsonSerializer.Deserialize<WeatherForecast>(jsonString);
            Console.WriteLine(obj.Date);
            Console.WriteLine(obj.TemperatureCelsius);
            Console.WriteLine(obj.Summary);



        }
        

        public void XmlSerialize()  // convert object information into xml format for transferring over the network
        {
            Employee bs = new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            TextWriter txtWriter = new StreamWriter(@"C:\UNext\Serialization.xml");
            xs.Serialize(txtWriter, bs);   
            txtWriter.Close();

        }

        public void XmlDeSerialize() // Convert xml file to original file
        {
            Employee bs = new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            StreamReader reader = new StreamReader(@"C:\UNext\Serialization.xml");
            bs = (Employee)xs.Deserialize(reader);
            Console.WriteLine("Employee Details");
            Console.WriteLine("Id: "+bs.Id);
            Console.WriteLine("Name:"+bs.name);
            Console.WriteLine("Subject: " + bs.subject); 
          
        }
    }
}
