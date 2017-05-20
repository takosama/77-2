using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77式夜戦模擬計算機
{
   public struct Ship
    {
        public string Name { get; set; }
        public int LV { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }

        public int ID { get; set; }
        public int ShipID        {get;set;}
        public int POW           {get;set;}
        public int TP            {get;set;}
        public int AirDEF        {get;set;}
        public int DEF           {get;set;}
        public int SubDEF        {get;set;}
        public int Shirk         {get;set;}
        public int Search        {get;set;}
        public int Speed         {get;set;}
        public int Luckey        {get;set;}
        public int[] AirCraftNum {get;set;}
        public int[] WeaponId    {get;set;}
        public int Cond          {get;set;}
      
        static public Ship GetShipFromJson(KCJsonClass.ApiShipData s)
        {
            var rtn = new Ship();
            rtn.Cond = s.api_cond;
            rtn.ID = s.api_id;
            rtn.Shirk = s.api_kaihi[0];
            rtn.POW = s.api_karyoku[0];
            rtn.Luckey = s.api_lucky[0];
            rtn.LV = s.api_lv;
            rtn.MaxHP = s.api_maxhp;
            rtn.HP = s.api_nowhp;
            rtn.TP = s.api_raisou[0];
            rtn.Search = s.api_sakuteki[0];
            rtn.ShipID = s.api_ship_id;
            rtn.DEF = s.api_soukou[0];
            rtn.AirDEF = s.api_taiku[0];
            rtn.SubDEF = s.api_taisen[0];
            rtn.Name = ShipData.GetShipStatus(rtn.ShipID, ShipData.StatusName.艦名);
            return rtn;
        }
    }

    class ShipData
    {
        public enum StatusName
        {
            艦船ID,
            図鑑番号,
            艦名,
            読み,
            艦種,
            改装前,
            改装後,
            改装Lv,
            改装弾薬,
            改装鋼材,
            改装設計図,
            カタパルト,
            耐久初期,
            耐久最大,
            耐久結婚,
            火力初期,
            火力最大,
            雷装初期,
            雷装最大,
            対空初期,
            対空最大,
            装甲初期,
            装甲最大,
            対潜初期最小,
            対潜初期最大,
            対潜最大,
            対潜155最小,
            対潜155最大,
            回避初期最小,
            回避初期最大,
            回避最大,
            回避155最小,
            回避155最大,
            索敵初期最小,
            索敵初期最大,
            索敵最大,
            索敵155最小,
            索敵155最大,
            運初期,
            運最大,
            速力,
            射程,
            レア,
            スロット数,
            搭載機数1,
            搭載機数2,
            搭載機数3,
            搭載機数4,
            搭載機数5,
            初期装備1,
            初期装備2,
            初期装備3,
            初期装備4,
            初期装備5,
            建造時間,
            解体燃料,
            解体弾薬,
            解体鋼材,
            解体ボーキ,
            改修火力,
            改修雷装,
            改修対空,
            改修装甲,
            ドロップ文章,
            図鑑文章,
            搭載燃料,
            搭載弾薬,
            ボイス,
            リソース名,
            画像バージョン,
            ボイスバージョン,
            母港ボイスバージョン
        }
        static bool IsInited = false;
        static Dictionary<int, string[]> DataDic = new Dictionary<int, string[]>();
        static void InitDataTable()
        {
            System.IO.StreamReader sr = new System.IO.StreamReader("艦これステータス.csv", System.Text.Encoding.GetEncoding("shift_jis"));
            var str = sr.ReadLine();
            int i = 0;
            while (true)
            {
                str = sr.ReadLine();
                if (str == null) break;
                DataDic.Add(int.Parse(str.Split(',')[0]), str.Split(',').ToArray());
            }
            sr.Close();
            IsInited = true;
        }
        public static string GetShipStatus(int ShipID, StatusName n)
        {
            if (ShipID == -1) return "";
            if (!IsInited)
                InitDataTable();
            string[] buf;
            bool IsFound = DataDic.TryGetValue(ShipID, out buf);
            if (IsFound)
                return buf[(int)n];
            else
                return "";
        }
      
    }

    class Deck
    {
        public int FleetNember = 6;
        Ship[] Ships;
        public Deck()
        {
            Clear();
        }
        public Ship[] GetMenber()
        {
            return (Ship[])Ships.Clone();
        }
        public void SetDeck(Ship ship,int n)
        {
            this.Ships[n - 1] = ship;
        }

        public void Clear()
        {
            Ships = new Ship[FleetNember]; 
        }
    }

    class Decks
    {
        Deck[] Deck;
        public Decks(int n) => Deck = new Deck[n];
        public void Set(Deck d, int n) => this.Deck[n - 1] = d;
        public void Delete(int n) => this.Deck[n - 1] = new Deck();
    }


    class MotherPort
    {
        static public Ship[] Ships = new Ship[0];
        static public int[] Materials = new int[8];
        public enum MaterialName
        {
            Oil,
            Amo,
            Iron,
            Bauxite,
            Burner,
            Bucket,
            Deverop,
            Screw
        }
        static public void Refresh(KCJsonClass.MotherPortClass.RootObject m)
        {
            for (int i = 0; i < 8; i++)
            {
                Materials[i] = m.api_data.api_material[i].api_value;
            }
            SeMotherPortFromJson(m);
        }

        static void SeMotherPortFromJson(KCJsonClass.MotherPortClass.RootObject j)
        {
            MotherPort.Ships = new Ship[j.api_data.api_ship.Count];
            for (int i = 0; i < Ships.Length; i++)
                Ships[i] = Ship.GetShipFromJson(j.api_data.api_ship[i]);
        }
    }
}
    