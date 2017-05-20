using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Text.RegularExpressions;

namespace _77式夜戦模擬計算機
{
    class JSONAnalysis
    {
        public VirtualKCMaschine.JsonStatus JudgeStatus(string FileName)
        {
            if(FileName.IndexOf("S@api_get_member@ship_deck")!=-1)
                return VirtualKCMaschine.JsonStatus.DeckInMap;
            if (FileName.IndexOf("S@api_req_sortie@battleresult.json") != -1)
                return VirtualKCMaschine.JsonStatus.BattleResult;
            if (FileName.IndexOf("S@api_req_sortie@battle.json") != -1)
                return VirtualKCMaschine.JsonStatus.BattleStart;
            return VirtualKCMaschine.JsonStatus.UnKnown;
        }
        public string LoadJSON(string FileName)
        {
            if (FileName.IndexOf("json") == -1) return "";
            StreamReader sr;
            while (true)
                try
                {
                    sr = new StreamReader(FileName);
                    break;
                }
                catch
                {

                }
            var rtn = sr.ReadToEnd();
            //UnicodeをUTFに
            rtn = Regex.Replace(rtn, "\\\\u(?<code>[0-9a-fA-F]{4})", (Match m) =>
            {
                int code = Convert.ToInt32(m.Groups["code"].Value, 16);
                return ((char)code).ToString();
            });
            sr.Close();
            rtn = rtn.Substring(7);
            return rtn;
        }
    }
}
