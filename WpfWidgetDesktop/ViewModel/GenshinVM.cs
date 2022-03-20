using DGP.Genshin.GamebarWidget.MiHoYoAPI;
using DGP.Genshin.GamebarWidget.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using WpfWidgetDesktop.Model;
using WpfWidgetDesktop.Utils;

namespace WpfWidgetDesktop.ViewModel
{
    public class GenshinVM
    {

        //private static List<RoleAndNote> roleAndNotes = new List<RoleAndNote>();

        private class Cfg
        {
            public string Cookie { get; set; }

        }
        private Cfg cfg;
        private DispatcherTimer dt = new DispatcherTimer();
        private readonly string id = "mihoyo.genshin";
        public static GenshinModel myVm { get; set; } = new GenshinModel();

        public void Save() {
            cfg.Cookie = myVm.Edited;
            SettingProvider.Set(id, cfg);
        }


        public GenshinVM()
        {
            cfg = JsonConvert.DeserializeObject<Cfg>(SettingProvider.Get(id));
            if (cfg == null)
            {
                cfg = new Cfg();
                cfg.Cookie = "";
            }

            dt.Interval = TimeSpan.FromMinutes(8);
            dt.Tick += dt_Tick;
            dt.Start();
        }
        private void dt_Tick(object o, EventArgs e)
        {
            Refresh();

        }
        public static async Task RefreshDailyNotePoolAsync(string mycookie)
        {

            if (mycookie == "" | mycookie == null)
            {
                MessageBox.Show("未设置cookie!", "提示");

                return;
            }

            Cookie cookie = new Cookie(mycookie);


            List<UserGameRole> roles = await new UserGameRoleProvider(cookie.CookieValue).GetUserGameRolesAsync();
            //roleAndNotes.Clear();
            if (roles.Count <1)
            {
                MessageBox.Show("错误的Cookie或者无网络!","提示");
                return;
            }
            foreach (UserGameRole role in roles)
            {
                DailyNote note = await new DailyNoteProvider(cookie.CookieValue).GetDailyNoteAsync(role.Region, role.GameUid);
                //roleAndNotes.Add(new RoleAndNote { Role = role, Note = note });
                myVm.RoleAndNote = new RoleAndNote { Role = role, Note = note };
            }


        }
        public void Refresh()
        {
           RefreshDailyNotePoolAsync(cfg.Cookie);
        }
    }
}
