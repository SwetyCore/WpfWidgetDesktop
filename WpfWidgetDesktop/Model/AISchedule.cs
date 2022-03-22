using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWidgetDesktop.Common;
using static WpfWidgetDesktop.Model.AIScheduleObj;

namespace WpfWidgetDesktop.Model
{
    public class AIScheduleObj
    {
        public class CoursesItem
            {
                /// <summary>
                /// 
                /// </summary>
                public int attendTime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int createTime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int ctId { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int day { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string extend { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string id { get; set; }
                /// <summary>
                /// 农学基础
                /// </summary>
                public string name { get; set; }
                /// <summary>
                /// 三江楼0402
                /// </summary>
                public string position { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public List<string> sectionList { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string sections { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string style { get; set; }
                /// <summary>
                /// 赵玉国/倪纪恒
                /// </summary>
                public string teacher { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int updateTime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string weeks { get; set; }
            }

        public class Setting
        {
            /// <summary>
            /// 
            /// </summary>
            public int afternoonNum { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int confirm { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int createTime { get; set; }
            /// <summary>
            /// {"startSemester":1645372800000,"degree":"本科/专科","showNotInWeek":true,"bgSetting":{"name":"default","opacity":1}}
            /// </summary>
            public string extend { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int isWeekend { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int morningNum { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int nightNum { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int presentWeek { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string school { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string sectionTimes { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int speak { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string startSemester { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int totalWeek { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int updateTime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int weekStart { get; set; }
        }

        public class CourseData
        {
            /// <summary>
            /// 
            /// </summary>
            public List<CoursesItem> courses { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int current { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// 大二下
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Setting setting { get; set; }
        }

        public class TableRoot
        {
            /// <summary>
            /// 
            /// </summary>
            public int code { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public CourseData data { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string desc { get; set; }
        }
    }
    


    public class AIScheduleModel:NotifyBase
    {
        private List<CoursesItem> _ci;

        public List<CoursesItem> CI
        {
            get { return _ci; }
            set { _ci = value;this.DoNotify(); }
        }

        private string _week;

        public string Week
        {
            get { return _week; }
            set { _week = value; this.DoNotify(); }
        }

        private string _day;

        public string Day
        {
            get { return _day; }
            set { _day = value; this.DoNotify(); }
        }



    }
}
