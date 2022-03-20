using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWidgetDesktop.Common;

namespace WpfWidgetDesktop.Model
{
    public class CountDownModel:NotifyBase
    {
        private string _eventName;

        public string EventName
        {
            get { return _eventName; }
            set { _eventName = value; this.DoNotify(); }
        }
        private string _target;

        public string Target
        {
            get { return _target; }
            set { _target = value; this.DoNotify(); }
        }

        private string _time;

        public string SelectedTime
        {
            get { return _time; }
            set { _time = value; this.DoNotify(); }
        }

        private DateTime _selectedDate;

        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set { _selectedDate = value;this.DoNotify(); }
        }
        private string _leftTime;

        public string LeftTime
        {
            get { return _leftTime; }
            set { _leftTime = value; this.DoNotify(); }
        }


        private string _unit;

        public string Unit
        {
            get { return _unit; }
            set { _unit = value; this.DoNotify(); }
        }

        private string _editedName;

        public string EditedName
        {
            get { return _editedName; }
            set { _editedName = value; this.DoNotify(); }
        }
    }
}
