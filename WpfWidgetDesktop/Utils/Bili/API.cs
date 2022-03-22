using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WpfWidgetDesktop.Utils.Bili
{
    //https://github.com/SocialSisterYi/bilibili-API-collect
    public class API
    {
        Request Request { get; set; }
        public API()
        {
            Request = new Request();
        }
        public async Task <string> GetSpaceInfo()
        {
            string api = "http://api.bilibili.com/x/space/acc/info";
            //
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["mid"] = User.mid;
            string resp=await Request.Get(api,data);
            return resp;

        }

        public async Task<string> GetMyInfo()
        {
            string api = "http://api.bilibili.com/x/space/myinfo";
            string resp = await Request.Get(api);
            return resp;
        }
        public async Task<string> GetCard()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["mid"]=User.mid;
            data["photo"] = "true";
            string api = "http://api.bilibili.com/x/web-interface/card";
            string resp = await Request.Get(api,data);
            return resp;
        }
    }
}
