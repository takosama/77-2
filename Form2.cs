using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _77式夜戦模擬計算機
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        delegate void RefrshFromJson_d(VirtualKCMaschine.JsonStatus Status, VirtualKCMaschine VM);
        public void RefreshFromJson_m(VirtualKCMaschine.JsonStatus status, VirtualKCMaschine VM)
        {
            if(status==VirtualKCMaschine.JsonStatus.BattleResult)
            {
                Console.WriteLine(VM.battleResult.Name);
                Console.WriteLine(VM.battleResult.Type);
                Console.WriteLine(VM.battleResult.DropMes.Replace("<br>","\n"));
            }
        } 



        public void RefreshFromJson(VirtualKCMaschine.JsonStatus s,VirtualKCMaschine VM)
        {
            Invoke(new RefrshFromJson_d(RefreshFromJson_m),s,VM);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
