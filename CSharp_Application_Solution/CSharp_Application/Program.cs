using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // For File Reading

namespace CSharp_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {

            { /*int a;
            int b;
            int c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;

            //Displaying output
            Console.WriteLine(c);
            Console.Read();     // For keyboard input.*/

                //Movie movieObj = new Movie();
                ////movieObj.CreateMovie();
                //movieObj.SelectMovies();

                //// Console.WriteLine(
                //Console.ReadLine();

                // SerializationDemo srlObj = new SerializationDemo();
                //srlObj.XmlDeSerialize();
                //srlObj.JsonSerialize();

                //Console.ReadLine(); }





            } 

            //FileStream fileObj = new FileStream(@"\C:UNext\PersonDetails.txt", FileMode.CreateNew, FileAccess.Write);
            //StreamWriter streamObj = new StreamWriter(fileObj);
            //streamObj.Write(personObj.name);
            //streamObj.Write(personObj.age);
            //streamObj.Write(personObj.city);
            //fileObj.Close();
            //streamObj.Close();
            Person person = new Person();
            //person.XmlSerialize();
            //person.XmlDeSerialize();
            person.JsonSerialize();
            Console.WriteLine("\n\t\t\tThis person has the capacity to disrupt the world order single handedly.");
            Console.Clear();
            Console.ReadLine();

        }



    }
}