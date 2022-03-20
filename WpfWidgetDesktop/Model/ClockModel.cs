using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWidgetDesktop.Common;

namespace WpfWidgetDesktop.Model
{
    public class ClockModel:NotifyBase
    {
        private string _hourAndMinute;

        public string HourAndMinute
        {
            get { return _hourAndMinute; }
            set { _hourAndMinute = value; this.DoNotify(); }
        }

        private string _second;

        public string Second
        {
            get { return _second; }
            set { _second = value;  this.DoNotify(); }
        }

        private string _week;

        public string Week
        {
            get { return _week; }
            set { _week = value; this.DoNotify(); }
        }

        private string _date;

        public string Date
        {
            get { return _date; }
            set { _date = value; this.DoNotify(); }
        }



    }
}
