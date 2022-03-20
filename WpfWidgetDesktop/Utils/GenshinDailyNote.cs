using DGP.Genshin.GamebarWidget.MiHoYoAPI;
using DGP.Genshin.GamebarWidget.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWidget2.Utils
{
    public static class GenshinDailyNote
    {
        static List<RoleAndNote> roleAndNotes = new List<RoleAndNote>();
        public static async Task RefreshDailyNotePoolAsync()
        {
            if (Settings1.Default.MihoyoCookie == "")
            {
                return;
            }
            Cookie cookie = new Cookie(Settings1.Default.MihoyoCookie);

            
            List<UserGameRole> roles = await new UserGameRoleProvider(cookie.CookieValue).GetUserGameRolesAsync();
            roleAndNotes.Clear();
            if (roles.Count == 0)
            {
                return;
            }
            foreach (UserGameRole role in roles)
            {
                DailyNote note = await new DailyNoteProvider(cookie.CookieValue).GetDailyNoteAsync(role.Region, role.GameUid);
                roleAndNotes.Add(new RoleAndNote { Role = role, Note = note });
            }


        }

    }
}
