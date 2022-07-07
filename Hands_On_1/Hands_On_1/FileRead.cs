using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //File Reading 


namespace Hands_On_1
{
    internal class FileRead
    {
        public void Read_file()
        {
            
        public int Id, src;
        public double dst;
        string date, status, network;

        FileStream fileObj = new FileStream(@"C:\UNext\networklog.txt", FileMode.Open, FileAccess.Read);
        StreamReader strObj = new StreamReader(fileObj);
        int flag = 1;

        while(!strObj.EndOfStream)
        {if(flag==1)
            while(strObj.peek())


    }

}
    }
        
    
}
