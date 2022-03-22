using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWidgetDesktop.Common;
using static WpfWidgetDesktop.Utils.Bili.DataFormat;

namespace WpfWidgetDesktop.Model
{
    public class BiliModel:NotifyBase
    {
        private space_acc_info.Root _Acc_Info;

        public space_acc_info.Root Acc_Info
        {
            get { return _Acc_Info; }
            set { _Acc_Info = value; DoNotify(); }
        }

        private space_myinfo.Root _space_Myinfo;

        public space_myinfo.Root Space_Myinfo
        {
            get { return _space_Myinfo; }
            set { _space_Myinfo = value; this.DoNotify(); }
        }

        private web_interface_card.Root _card;

        public web_interface_card.Root Card
        {
            get { return _card; }
            set { _card = value; DoNotify(); }
        }

        private string _cookie;

        public string Cookie
        {
            get { return _cookie; }
            set { _cookie = value; DoNotify(); }
        }


    }
}
