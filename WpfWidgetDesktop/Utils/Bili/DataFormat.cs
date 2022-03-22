using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWidgetDesktop.Utils.Bili
{
    public class DataFormat
    {
        /// <summary>
        /// https://api.bilibili.com/x/space/acc/info?mid=[mid]
        /// </summary>
        public class space_acc_info
        {
            public class Medal
            {
                /// <summary>
                /// 
                /// </summary>
                public int uid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int target_id { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int medal_id { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int level { get; set; }
                /// <summary>
                /// 小雕们
                /// </summary>
                public string medal_name { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int medal_color { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int intimacy { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int next_intimacy { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int day_limit { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int medal_color_start { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int medal_color_end { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int medal_color_border { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int is_lighted { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int light_status { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int wearing_status { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int score { get; set; }
            }

            public class Fans_medal
            {
                /// <summary>
                /// 
                /// </summary>
                public string show { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string wear { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Medal medal { get; set; }
            }

            public class Official
            {
                /// <summary>
                /// 
                /// </summary>
                public int role { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string title { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string desc { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int type { get; set; }
            }

            public class Label
            {
                /// <summary>
                /// 
                /// </summary>
                public string path { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string text { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string label_theme { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string text_color { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int bg_style { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bg_color { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string border_color { get; set; }
            }

            public class Vip
            {
                /// <summary>
                /// 
                /// </summary>
                public int type { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int status { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string due_date { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int vip_pay_type { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int theme_type { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Label label { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int avatar_subscript { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string nickname_color { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int role { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string avatar_subscript_url { get; set; }
            }

            public class Pendant
            {
                /// <summary>
                /// 
                /// </summary>
                public int pid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string name { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int expire { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image_enhance { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image_enhance_frame { get; set; }
            }

            public class Nameplate
            {
                /// <summary>
                /// 
                /// </summary>
                public int nid { get; set; }
                /// <summary>
                /// 青铜殿堂
                /// </summary>
                public string name { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image_small { get; set; }
                /// <summary>
                /// 普通勋章
                /// </summary>
                public string level { get; set; }
                /// <summary>
                /// 单个自制视频总播放数>=1万
                /// </summary>
                public string condition { get; set; }
            }

            public class User_honour_info
            {
                /// <summary>
                /// 
                /// </summary>
                public int mid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string colour { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public List<string> tags { get; set; }
            }

            public class Theme
            {
            }

            public class Sys_notice
            {
            }

            public class School
            {
                /// <summary>
                /// 江苏大学
                /// </summary>
                public string name { get; set; }
            }

            public class Profession
            {
                /// <summary>
                /// 
                /// </summary>
                public string name { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string department { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string title { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int is_show { get; set; }
            }

            public class Series
            {
                /// <summary>
                /// 
                /// </summary>
                public int user_upgrade_status { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string show_upgrade_window { get; set; }
            }

            public class Data
            {
                /// <summary>
                /// 
                /// </summary>
                public int mid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string name { get; set; }
                /// <summary>
                /// 保密
                /// </summary>
                public string sex { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string face { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int face_nft { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string sign { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int rank { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int level { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int jointime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int moral { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int silence { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public double coins { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string fans_badge { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Fans_medal fans_medal { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Official official { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Vip vip { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Pendant pendant { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Nameplate nameplate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public User_honour_info user_honour_info { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string is_followed { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string top_photo { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Theme theme { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Sys_notice sys_notice { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string live_room { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string birthday { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public School school { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Profession profession { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string tags { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Series series { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int is_senior_member { get; set; }
            }

            public class Root
            {
                /// <summary>
                /// 
                /// </summary>
                public int code { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string message { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int ttl { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Data data { get; set; }
            }

        }
        /// <summary>
        /// http://api.bilibili.com/x/space/myinfo 需要登陆
        /// </summary>
        public class space_myinfo
        {
            public class Label
            {
                /// <summary>
                /// 
                /// </summary>
                public string path { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string text { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string label_theme { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string text_color { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int bg_style { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bg_color { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string border_color { get; set; }
            }

            public class Vip
            {
                /// <summary>
                /// 
                /// </summary>
                public int type { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int status { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string due_date { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int vip_pay_type { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int theme_type { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Label label { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int avatar_subscript { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string nickname_color { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int role { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string avatar_subscript_url { get; set; }
            }

            public class Pendant
            {
                /// <summary>
                /// 
                /// </summary>
                public int pid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string name { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int expire { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image_enhance { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image_enhance_frame { get; set; }
            }

            public class Nameplate
            {
                /// <summary>
                /// 
                /// </summary>
                public int nid { get; set; }
                /// <summary>
                /// 青铜殿堂
                /// </summary>
                public string name { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image_small { get; set; }
                /// <summary>
                /// 普通勋章
                /// </summary>
                public string level { get; set; }
                /// <summary>
                /// 单个自制视频总播放数>=1万
                /// </summary>
                public string condition { get; set; }
            }

            public class Official
            {
                /// <summary>
                /// 
                /// </summary>
                public int role { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string title { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string desc { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int type { get; set; }
            }

            public class Profession
            {
                /// <summary>
                /// 
                /// </summary>
                public int id { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string name { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string show_name { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int is_show { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string category_one { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string realname { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string title { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string department { get; set; }
            }

            public class Level_exp
            {
                /// <summary>
                /// 
                /// </summary>
                public int current_level { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int current_min { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int current_exp { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int next_exp { get; set; }
            }

            public class Data
            {
                /// <summary>
                /// 
                /// </summary>
                public int mid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string name { get; set; }
                /// <summary>
                /// 保密
                /// </summary>
                public string sex { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string face { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string sign { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int rank { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int level { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int jointime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int moral { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int silence { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int email_status { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int tel_status { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int identification { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Vip vip { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Pendant pendant { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Nameplate nameplate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Official official { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int birthday { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int is_tourist { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int is_fake_account { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int pin_prompting { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int is_deleted { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int in_reg_audit { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string is_rip_user { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Profession profession { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int face_nft { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int face_nft_new { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int is_senior_member { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Level_exp level_exp { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public double coins { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int following { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int follower { get; set; }
            }

            public class Root
            {
                /// <summary>
                /// 
                /// </summary>
                public int code { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string message { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int ttl { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Data data { get; set; }
            }

        }


        public class web_interface_card
        {
            public class Level_info
            {
                /// <summary>
                /// 
                /// </summary>
                public int current_level { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int current_min { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int current_exp { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int next_exp { get; set; }
            }

            public class Pendant
            {
                /// <summary>
                /// 
                /// </summary>
                public int pid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string name { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int expire { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image_enhance { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image_enhance_frame { get; set; }
            }

            public class Nameplate
            {
                /// <summary>
                /// 
                /// </summary>
                public int nid { get; set; }
                /// <summary>
                /// 青铜殿堂
                /// </summary>
                public string name { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string image_small { get; set; }
                /// <summary>
                /// 普通勋章
                /// </summary>
                public string level { get; set; }
                /// <summary>
                /// 单个自制视频总播放数>=1万
                /// </summary>
                public string condition { get; set; }
            }

            public class Official
            {
                /// <summary>
                /// 
                /// </summary>
                public int role { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string title { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string desc { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int type { get; set; }
            }

            public class Official_verify
            {
                /// <summary>
                /// 
                /// </summary>
                public int type { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string desc { get; set; }
            }

            public class Label
            {
                /// <summary>
                /// 
                /// </summary>
                public string path { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string text { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string label_theme { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string text_color { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int bg_style { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bg_color { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string border_color { get; set; }
            }

            public class Vip
            {
                /// <summary>
                /// 
                /// </summary>
                public int type { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int status { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string due_date { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int vip_pay_type { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int theme_type { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Label label { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int avatar_subscript { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string nickname_color { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int role { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string avatar_subscript_url { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int vipType { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int vipStatus { get; set; }
            }

            public class Card
            {
                /// <summary>
                /// 
                /// </summary>
                public string mid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string name { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string approve { get; set; }
                /// <summary>
                /// 保密
                /// </summary>
                public string sex { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string rank { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string face { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int face_nft { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string DisplayRank { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int regtime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int spacesta { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string birthday { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string place { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string description { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int article { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public List<string> attentions { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int fans { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int friend { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int attention { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string sign { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Level_info level_info { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Pendant pendant { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Nameplate nameplate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Official Official { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Official_verify official_verify { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Vip vip { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int is_senior_member { get; set; }
            }

            public class Space
            {
                /// <summary>
                /// 
                /// </summary>
                public string s_img { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string l_img { get; set; }
            }

            public class Data
            {
                /// <summary>
                /// 
                /// </summary>
                public Card card { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Space space { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string following { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int archive_count { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int article_count { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int follower { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int like_num { get; set; }
            }

            public class Root
            {
                /// <summary>
                /// 
                /// </summary>
                public int code { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string message { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int ttl { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public Data data { get; set; }
            }

        }
    }
}
