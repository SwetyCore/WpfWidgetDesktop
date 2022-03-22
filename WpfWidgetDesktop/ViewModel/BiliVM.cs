using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfWidgetDesktop.Model;
using WpfWidgetDesktop.Utils;
using static WpfWidgetDesktop.Utils.Bili.DataFormat;

namespace WpfWidgetDesktop.ViewModel
{
    public class BiliVM
    {
        private class Cfg
        {
            public string Cookie { get; set; }

        }
        private Cfg cfg;

        private readonly string id = "bili.bilibili";
        Utils.Bili.API api = new();
        public BiliModel myVm { get; set; } = new();
        public BiliVM()
        {
            //GetMyInfo();

            cfg = JsonConvert.DeserializeObject<Cfg>(SettingProvider.Get(id));
            if (cfg == null)
            {
                cfg = new Cfg();
                cfg.Cookie = "";
            }
            else
            {
                Utils.Bili.User.Cookie = cfg.Cookie;
                Utils.Bili.User.mid = Utils.Bili.User.GetMidFromCookie(cfg.Cookie);
            }
        }

        //public async void GetUserInfo()
        //{
            

        //}
        //public async void GetMyInfo()
        //{

        //    string resp = await api.GetMyInfo();
        //    myVm.Space_Myinfo = JsonConvert.DeserializeObject<space_myinfo.Root>(resp);
        //}


        /// <summary>
        /// http://api.bilibili.com/x/web-interface/card?mid=196435612&photo=true
        /// </summary>
        public async void GetCard(bool tip=true)
        {
            if (cfg.Cookie != null && cfg.Cookie != ""&&Utils.Bili.User.mid!="")
            {
                try
                {

                    string resp = await api.GetCard();

                    myVm.Card = JsonConvert.DeserializeObject<web_interface_card.Root>(resp);
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (tip)
            {
                MessageBox.Show("哔哩哔哩:无效的Cookie!");
            }
        }

        public void Save()
        {
            cfg.Cookie = myVm.Cookie;
            Utils.Bili.User.Cookie = cfg.Cookie;
            Utils.Bili.User.mid = Utils.Bili.User.GetMidFromCookie(cfg.Cookie);
            if (Utils.Bili.User.mid=="")
            {
                MessageBox.Show("无效的Cookie!");
            }
            SettingProvider.Set(id, cfg);
            GetCard();
        }
    }
}
