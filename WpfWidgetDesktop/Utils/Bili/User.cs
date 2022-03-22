using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWidgetDesktop.Utils.Bili
{
    public static class User
    {
        public static string mid = "";
        public static string Cookie = "";
        public static string GetMidFromCookie(string cookie)
        {
            List <string> DedeUserID = cookie.Split("; ").Where(x=> x.IndexOf("DedeUserID=")!=-1).ToList();
            if (DedeUserID.Count == 0)
            {
                return "";
            }
            else
            {
                return DedeUserID[0].Replace("DedeUserID=","");
            }
        }
    }


    
}
