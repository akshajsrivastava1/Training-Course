using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //File handling 

namespace CSharp_Application
{
    internal class Movie
    {
        public string movieID, movieName, movieDesc, movieLang;
        public void CreateMovie()
        {   //Getting the details of movies from user by using Console.Readline() and saving them in a variable
            //We will be passing these variables in the StreamWriter function.

            Console.WriteLine("Please Enter the Movie ID : ");
            movieID = Console.ReadLine();

            Console.WriteLine("Please Enter the Movie Name : ");
            movieName = Console.ReadLine();

            Console.WriteLine("Please Enter the Movie Description : ");
            movieDesc = Console.ReadLine();

            Console.WriteLine("Please Enter the Movie Language : ");
            movieLang = Console.ReadLine();

            //Values input successfully

            //Creating a file
            FileStream fileStreamObj = new FileStream(@"C:\UNext\movie.txt",FileMode.Create,FileAccess.Write);

            //How to write a file

            StreamWriter streamWriter = new StreamWriter(fileStreamObj);
            streamWriter.WriteLine("Movie ID : " + movieID);
            streamWriter.WriteLine("Movie Name : " + movieName);
            streamWriter.WriteLine("Movie Langauge : " + movieLang);
            streamWriter.WriteLine("Movie Description : " + movieDesc);
            streamWriter.Close(); // Closing the file writing stream. Very Necessary
            fileStreamObj.Close(); //Closing the file object
            Console.WriteLine("File Operation completed");
        }
        //
        public void SelectMovies()
        {
            
            FileStream fileObj = new FileStream(@"C:\UNext\movie.txt", FileMode.Open, FileAccess.Read);
            StreamReader SrObj = new StreamReader(fileObj);
            while(!SrObj.EndOfStream)
            {
                Console.WriteLine(SrObj.ReadLine()); // Reading a line from the file. 
            }
            
            while(SrObj.Peek()>0)
            { Console.WriteLine(SrObj.ReadLine()); }

            Console.WriteLine(SrObj.ReadToEnd()); 

        }
     
    }
}
