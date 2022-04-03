using MyWidget2.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfWidgetDesktop.Model;
using static WpfWidgetDesktop.Model.AIScheduleObj;

namespace WpfWidgetDesktop.ViewModel
{


    public class AIScheduleVM
    {
        public AIScheduleModel myVm { get; set; }
        public AIScheduleObj.Setting setting { get; set; }
        public AIScheduleVM()
        {
            myVm = new AIScheduleModel();
            LoadTable(false);
        }

        private bool IsIn(string[] a,string b)
        {
            Console.WriteLine(a);
            foreach (string a2 in a)
            {
                if (a2 == b) { return true; }
            }
            return false;
        }
        public int Week2Int(DayOfWeek w)
        {
            var a=Convert.ToInt32(w);
            if (a == 0)
            {
                return 7;
            }
            else
            {
                return a;
            }
        }


        public async void LoadTable(bool tip=true)
        {
            try
            {
                string table =await File.ReadAllTextAsync("./Config/table.json");
                TableRoot tr = JsonConvert.DeserializeObject<TableRoot>(table);
                setting = tr.data.setting;
                var week=Update();

                myVm.CI = tr.data.courses.Where(x => IsIn(x.weeks.Split(','),week)&&x.day== Week2Int( DateTime.Now.DayOfWeek)).ToList();

            }
            catch (Exception ex)
            {
                if (tip)
                {
                    var a = MessageBox.Show("还未设置课程表,是否打开课表文件夹?", "提示", MessageBoxButton.OKCancel);
                    if (a == MessageBoxResult.OK)
                    {
                        BasicMethods.runcmd("explorer Config");

                    }
                }
                
            }
            
        }
        public string Week2CN()
        {
            string[] weekdays = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            string week = weekdays[Convert.ToInt32(DateTime.Now.DayOfWeek)];

            return week;
        }
        private string Update()
        {
            string Start = setting.startSemester;
            DateTime start = BasicMethods.StampToDateTime(Start);
            TimeSpan ts=DateTime.Now - start;
            int week = (int)Math.Floor((double)ts.Days / 7)+1;
            myVm.Week = $"第 {week} 周 ";
            myVm.Day = $"{Week2CN()}";
            return week.ToString();
        }

    }
}
