using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using WpfWidgetDesktop.Model;

namespace WpfWidgetDesktop.ViewModel
{
    public class ClockViewModel
    {
        public ClockModel clockModel { get; set; } =new ClockModel();
        private DispatcherTimer dt = new DispatcherTimer();

        public string Week()
        {
            string[] weekdays = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            string week = weekdays[Convert.ToInt32(DateTime.Now.DayOfWeek)];

            return week;
        }

        void dt_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            clockModel.Date = now.ToString("D");
            clockModel.HourAndMinute = now.ToString("t");
            clockModel.Second= $":{now.ToString("ss")}";
            clockModel.Week = Week();
        }

        public ClockViewModel()
        {
            dt.Interval = TimeSpan.FromSeconds(0.1);
            dt.Tick+=dt_Tick;
            dt.Start();
        }




    }
}
