using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77式夜戦模擬計算機
{
 public   class KCJsonClass
    {
        public class ApiShipData
        {
            public int api_id { get; set; }
            public int api_sortno { get; set; }
            public int api_ship_id { get; set; }
            public int api_lv { get; set; }
            public List<int> api_exp { get; set; }
            public int api_nowhp { get; set; }
            public int api_maxhp { get; set; }
            public int api_soku { get; set; }
            public int api_leng { get; set; }
            public List<int> api_slot { get; set; }
            public List<int> api_onslot { get; set; }
            public int api_slot_ex { get; set; }
            public List<int> api_kyouka { get; set; }
            public int api_backs { get; set; }
            public int api_fuel { get; set; }
            public int api_bull { get; set; }
            public int api_slotnum { get; set; }
            public int api_ndock_time { get; set; }
            public List<int> api_ndock_item { get; set; }
            public int api_srate { get; set; }
            public int api_cond { get; set; }
            public List<int> api_karyoku { get; set; }
            public List<int> api_raisou { get; set; }
            public List<int> api_taiku { get; set; }
            public List<int> api_soukou { get; set; }
            public List<int> api_kaihi { get; set; }
            public List<int> api_taisen { get; set; }
            public List<int> api_sakuteki { get; set; }
            public List<int> api_lucky { get; set; }
            public int api_locked { get; set; }
            public int api_locked_equip { get; set; }
            public int api_sally_area { get; set; }
        }

        public class GetShipDeck
        {


            public class ApiDeckData
            {
                public int api_member_id { get; set; }
                public int api_id { get; set; }
                public string api_name { get; set; }
                public string api_name_id { get; set; }
                public List<int> api_mission { get; set; }
                public string api_flagship { get; set; }
                public List<int> api_ship { get; set; }
            }

            public class ApiData
            {
                public List<ApiShipData> api_ship_data { get; set; }
                public List<ApiDeckData> api_deck_data { get; set; }
            }

            public class RootObject
            {
                public int api_result { get; set; }
                public string api_result_msg { get; set; }
                public ApiData api_data { get; set; }
            }
        }
        public class BattleStart
        {
            public class ApiStage1
            {
                public int api_f_count { get; set; }
                public int api_f_lostcount { get; set; }
                public int api_e_count { get; set; }
                public int api_e_lostcount { get; set; }
                public int api_disp_seiku { get; set; }
                public List<int> api_touch_plane { get; set; }
            }

            public class ApiStage2
            {
                public int api_f_count { get; set; }
                public int api_f_lostcount { get; set; }
                public int api_e_count { get; set; }
                public int api_e_lostcount { get; set; }
            }

            public class ApiStage3
            {
                public List<int> api_frai_flag { get; set; }
                public List<int> api_erai_flag { get; set; }
                public List<int> api_fbak_flag { get; set; }
                public List<int> api_ebak_flag { get; set; }
                public List<int> api_fcl_flag { get; set; }
                public List<int> api_ecl_flag { get; set; }
                public List<double> api_fdam { get; set; }
                public List<double> api_edam { get; set; }
            }

            public class ApiKouku
            {
                public List<List<int>> api_plane_from { get; set; }
                public ApiStage1 api_stage1 { get; set; }
                public ApiStage2 api_stage2 { get; set; }
                public ApiStage3 api_stage3 { get; set; }
            }

            public class ApiHougeki1
            {
                public List<int> api_at_list { get; set; }
                public List<int> api_at_type { get; set; }
                public List<object> api_df_list { get; set; }
                public List<object> api_si_list { get; set; }
                public List<object> api_cl_list { get; set; }
                public List<object> api_damage { get; set; }
            }

            public class ApiHougeki2
            {
                public List<int> api_at_list { get; set; }
                public List<int> api_at_type { get; set; }
                public List<object> api_df_list { get; set; }
                public List<object> api_si_list { get; set; }
                public List<object> api_cl_list { get; set; }
                public List<object> api_damage { get; set; }
            }

            public class ApiRaigeki
            {
                public List<int> api_frai { get; set; }
                public List<int> api_erai { get; set; }
                public List<int> api_fdam { get; set; }
                public List<int> api_edam { get; set; }
                public List<int> api_fydam { get; set; }
                public List<int> api_eydam { get; set; }
                public List<int> api_fcl { get; set; }
                public List<int> api_ecl { get; set; }
            }

            public class ApiData
            {
                public int api_dock_id { get; set; }
                public List<int> api_ship_ke { get; set; }
                public List<int> api_ship_lv { get; set; }
                public List<int> api_nowhps { get; set; }
                public List<int> api_maxhps { get; set; }
                public int api_midnight_flag { get; set; }
                public List<List<int>> api_eSlot { get; set; }
                public List<List<int>> api_eKyouka { get; set; }
                public List<List<int>> api_fParam { get; set; }
                public List<List<int>> api_eParam { get; set; }
                public List<int> api_search { get; set; }
                public List<int> api_formation { get; set; }
                public List<int> api_stage_flag { get; set; }
                public ApiKouku api_kouku { get; set; }
                public int api_support_flag { get; set; }
                public object api_support_info { get; set; }
                public int api_opening_taisen_flag { get; set; }
                public object api_opening_taisen { get; set; }
                public int api_opening_flag { get; set; }
                public object api_opening_atack { get; set; }
                public List<int> api_hourai_flag { get; set; }
                public ApiHougeki1 api_hougeki1 { get; set; }
                public ApiHougeki2 api_hougeki2 { get; set; }
                public object api_hougeki3 { get; set; }
                public ApiRaigeki api_raigeki { get; set; }
            }

            public class RootObject
            {
                public int api_result { get; set; }
                public string api_result_msg { get; set; }
                public ApiData api_data { get; set; }
            }

        }

        public class BattleResult
        {
            public class ApiEnemyInfo
            {
                public string api_level { get; set; }
                public string api_rank { get; set; }
                public string api_deck_name { get; set; }
            }

            public class ApiGetShip
            {
                public int api_ship_id { get; set; }
                public string api_ship_type { get; set; }
                public string api_ship_name { get; set; }
                public string api_ship_getmes { get; set; }
            }

            public class ApiData
            {
                public List<int> api_ship_id { get; set; }
                public string api_win_rank { get; set; }
                public int api_get_exp { get; set; }
                public int api_mvp { get; set; }
                public int api_member_lv { get; set; }
                public int api_member_exp { get; set; }
                public int api_get_base_exp { get; set; }
                public List<int> api_get_ship_exp { get; set; }
                public List<List<int>> api_get_exp_lvup { get; set; }
                public int api_dests { get; set; }
                public int api_destsf { get; set; }
                public List<int> api_lost_flag { get; set; }
                public string api_quest_name { get; set; }
                public int api_quest_level { get; set; }
                public ApiEnemyInfo api_enemy_info { get; set; }
                public int api_first_clear { get; set; }
                public int api_mapcell_incentive { get; set; }
                public List<int> api_get_flag { get; set; }
                public ApiGetShip api_get_ship { get; set; }
                public int api_get_eventflag { get; set; }
                public int api_get_exmap_rate { get; set; }
                public int api_get_exmap_useitem_id { get; set; }
            }

            public class RootObject
            {
                public int api_result { get; set; }
                public string api_result_msg { get; set; }
                public ApiData api_data { get; set; }
            }
        }

        public class MotherPortClass
        {

            public class ApiMaterial
            {
                public int api_member_id { get; set; }
                public int api_id { get; set; }
                public int api_value { get; set; }
            }

            public class ApiDeckPort
            {
                public int api_member_id { get; set; }
                public int api_id { get; set; }
                public string api_name { get; set; }
                public string api_name_id { get; set; }
                public List<object> api_mission { get; set; }
                public string api_flagship { get; set; }
                public List<int> api_ship { get; set; }
            }

            public class ApiNdock
            {
                public int api_member_id { get; set; }
                public int api_id { get; set; }
                public int api_state { get; set; }
                public int api_ship_id { get; set; }
                public object api_complete_time { get; set; }
                public string api_complete_time_str { get; set; }
                public int api_item1 { get; set; }
                public int api_item2 { get; set; }
                public int api_item3 { get; set; }
                public int api_item4 { get; set; }
            }


            public class ApiBasic
            {
                public string api_member_id { get; set; }
                public string api_nickname { get; set; }
                public string api_nickname_id { get; set; }
                public int api_active_flag { get; set; }
                public long api_starttime { get; set; }
                public int api_level { get; set; }
                public int api_rank { get; set; }
                public int api_experience { get; set; }
                public object api_fleetname { get; set; }
                public string api_comment { get; set; }
                public string api_comment_id { get; set; }
                public int api_max_chara { get; set; }
                public int api_max_slotitem { get; set; }
                public int api_max_kagu { get; set; }
                public int api_playtime { get; set; }
                public int api_tutorial { get; set; }
                public List<int> api_furniture { get; set; }
                public int api_count_deck { get; set; }
                public int api_count_kdock { get; set; }
                public int api_count_ndock { get; set; }
                public int api_fcoin { get; set; }
                public int api_st_win { get; set; }
                public int api_st_lose { get; set; }
                public int api_ms_count { get; set; }
                public int api_ms_success { get; set; }
                public int api_pt_win { get; set; }
                public int api_pt_lose { get; set; }
                public int api_pt_challenged { get; set; }
                public int api_pt_challenged_win { get; set; }
                public int api_firstflag { get; set; }
                public int api_tutorial_progress { get; set; }
                public List<int> api_pvp { get; set; }
                public int api_medals { get; set; }
                public int api_large_dock { get; set; }
            }

            public class ApiLog
            {
                public int api_no { get; set; }
                public string api_type { get; set; }
                public string api_state { get; set; }
                public string api_message { get; set; }
            }

            public class ApiEventObject
            {
                public int api_m_flag { get; set; }
                public int api_m_flag2 { get; set; }
            }

            public class ApiData
            {
                public List<ApiMaterial> api_material { get; set; }
                public List<ApiDeckPort> api_deck_port { get; set; }
                public List<ApiNdock> api_ndock { get; set; }
                public List<ApiShipData> api_ship { get; set; }
                public ApiBasic api_basic { get; set; }
                public List<ApiLog> api_log { get; set; }
                public int api_combined_flag { get; set; }
                public int api_p_bgm_id { get; set; }
                public int api_parallel_quest_count { get; set; }
                public ApiEventObject api_event_object { get; set; }
            }

            public class RootObject
            {
                public int api_result { get; set; }
                public string api_result_msg { get; set; }
                public ApiData api_data { get; set; }
            }

        }

        public class MapNext
        {
            public class ApiAirsearch
            {
                public int api_plane_type { get; set; }
                public int api_result { get; set; }
            }

            public class ApiData
            {
                public int api_rashin_flg { get; set; }
                public int api_rashin_id { get; set; }
                public int api_maparea_id { get; set; }
                public int api_mapinfo_no { get; set; }
                public int api_no { get; set; }
                public int api_color_no { get; set; }
                public int api_event_id { get; set; }
                public int api_event_kind { get; set; }
                public int api_next { get; set; }
                public int api_bosscell_no { get; set; }
                public int api_bosscomp { get; set; }
                public int api_comment_kind { get; set; }
                public int api_production_kind { get; set; }
                public ApiAirsearch api_airsearch { get; set; }
            }

            public class RootObject
            {
                public int api_result { get; set; }
                public string api_result_msg { get; set; }
                public ApiData api_data { get; set; }
            }

        }
    }
}
