using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _77式夜戦模擬計算機
{

    static class Program
    {
        public static Form2 ShipsDataView = new Form2();
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfig.Load();
                FileWatcher fw = new FileWatcher();
                fw.FileWatchStart(@"C:\Users\takos\Desktop\ElectronicObserver\KCAPI",ShipsDataView);
                Application.Run(ShipsDataView);

                ApplicationConfig.Save();
            }
            catch
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("猫.txt", System.Text.Encoding.GetEncoding("shift-jis"));
                string str = sr.ReadToEnd();
                Console.WriteLine(str);
                Console.WriteLine("ソフトを再起動してください");
                Console.ReadLine();
            }
        }
    }
}
