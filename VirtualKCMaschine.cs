using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace _77式夜戦模擬計算機
{
   public class VirtualKCMaschine
    {
        Decks MyDeck = new Decks(4);
        Decks EnemyDeck = new Decks(2);
        Ship[] MotherPortShips;
        VMBattleResult VMresut = new VMBattleResult();
        public enum JsonStatus
        {
            DeckInMap,
            BattleResult,
            BattleStart,
            UnKnown
        }
  public      BattleResult battleResult = new BattleResult();
        public void OnReceiveJson(JsonStatus status,string JsonText)
        {
            if (status == JsonStatus.DeckInMap)
                return;
            if (status == JsonStatus.BattleResult)
               this.battleResult= VMresut.Call(JsonText);
        }

    }

   public struct BattleResult
    {
    public    string Name;
    public    string Type;
    public    string DropMes;
    }


    class VMBattleResult
    {
        public BattleResult Call(string JsonText)
        {
           var Json = JsonConvert.DeserializeObject<KCJsonClass.BattleResult.RootObject>(JsonText);
            if (Json.api_data.api_get_ship == null) return new BattleResult();
            var Drop  =Json.api_data.api_get_ship;

           BattleResult rtn;
            rtn.Name= Drop.api_ship_name;
           rtn.Type = Drop.api_ship_type;
            rtn.DropMes = Drop.api_ship_getmes;
            return rtn;
        }
    }

}
