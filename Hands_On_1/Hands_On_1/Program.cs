using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_On_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            FileRead fObj = new FileRead();
            fObj.Read_file();
            Console.ReadLine();
        }
    }
}
