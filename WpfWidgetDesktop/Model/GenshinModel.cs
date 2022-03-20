using DGP.Genshin.GamebarWidget.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWidgetDesktop.Common;

namespace WpfWidgetDesktop.Model
{
    public class GenshinModel:NotifyBase
    {
        private string _cookie;

        public string Cookie
        {
            get { return _cookie; }
            set { _cookie = value; this.DoNotify(); }
        }
        private string _edited;

        public string Edited
        {
            get { return _edited; }
            set { _edited = value; this.DoNotify(); }
        }
        private RoleAndNote _roleAndNote;

        public RoleAndNote RoleAndNote
        {
            get { return _roleAndNote; }
            set { _roleAndNote = value; this.DoNotify(); }
        }

    }
}
