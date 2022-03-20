using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWidgetDesktop.Common;

namespace WpfWidgetDesktop.Model
{
    public class PerformanceMonitorModel:NotifyBase
    {
        private string _cpu;

        public string CPU
        {
            get { return _cpu; }
            set { _cpu = value; this.DoNotify(); }
        }
        private string _mem;

        public string Mem
        {
            get { return _mem; }
            set { _mem = value; this.DoNotify(); }
        }

    }
}
