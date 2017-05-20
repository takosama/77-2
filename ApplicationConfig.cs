using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _77式夜戦模擬計算機
{
   static class ApplicationConfig
    {
        static public void Save()
        {
            StreamWriter sr = new StreamWriter(@"Config.dat");
            sr.WriteLine("BattelLogPath" + "=" + JsonPath +"\n");
            sr.Close();
        }

        static public void Load()
        {
            if (File.Exists(@"Config.dat"))
            {
             StreamReader sr = new StreamReader(@"Config.dat");
             
                
                string str = sr.ReadLine();
                JsonPath = str.Split('=')[1];

                sr.Close();
            }
        }

       static public string JsonPath = "";
    }
}
