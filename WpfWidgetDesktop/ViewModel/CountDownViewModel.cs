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
    public class CountDownViewModel
    {

        private readonly string id = "basic.countdown";
        public class Cfg 
        {
            public DateTime Date { get; set; }
            public string Event { get; set; }

        }
        private Cfg cfg;

        private DispatcherTimer dt = new DispatcherTimer();
        public CountDownModel myVm { get; set; }=new CountDownModel();

        public CountDownViewModel()
        {
            cfg = JsonConvert.DeserializeObject<Cfg>(SettingProvider.Get(id));
            if (cfg == null)
            {
                cfg = new Cfg();
                cfg.Date = DateTime.Now;
                cfg.Event = "指定事件";
            }
            myVm.Target=cfg.Date.ToString();
            myVm.EventName=cfg.Event;
            myVm.SelectedDate= DateTime.Now;

            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dt_Tick;
            dt.Start();
        }
        private void dt_Tick(object o,EventArgs e)
        {
            DateTime timeB = DateTime.Now;	//获取当前时间
            TimeSpan ts = cfg.Date - timeB; //计算时间差

            string time = "";
            if (ts.Days!=0){
                time = ts.Days.ToString();
                myVm.Unit = "天";
            }
            else if (ts.Hours != 0)
            {
                time = ts.Hours.ToString();
                myVm.Unit = "时";
            }
            else if (ts.Minutes != 0)
            {
                time = ts.Minutes.ToString();
                myVm.Unit = "分";
            }
            else if (ts.Seconds !=0)
            {
                time= ts.Seconds.ToString();
                myVm.Unit = "秒";
            }
            else
            {
                time = "过期";

                myVm.Unit = "";
            }
            myVm.LeftTime= time;
        }
        public void Save()
        {
            try
            {

                string datetime = myVm.SelectedDate.ToString("d") + $" { myVm.SelectedTime}";
                myVm.Target = datetime;
                myVm.EventName = myVm.EditedName;
                cfg.Date = DateTime.Parse(datetime);
                cfg.Event = myVm.EventName;
                SettingProvider.Set(id, cfg);
            }
            catch (Exception ex) {
                MessageBox.Show("时间格式错误,修改失败!");
            }
        }
    }

}
