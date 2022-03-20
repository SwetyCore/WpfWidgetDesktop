using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using WpfWidgetDesktop.Model;
using WpfWidgetDesktop.Utils;

namespace WpfWidgetDesktop.ViewModel
{

    public class PerformanceMonitorVM
    {
        private DispatcherTimer dt = new DispatcherTimer();
        SysParams sysParams = new SysParams();
        public PerformanceMonitorModel myVm { get; set; } = new PerformanceMonitorModel();
        public PerformanceMonitorVM()
        {

            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dt_Tick;
            dt.Start();
        }


        void dt_Tick(object sender, EventArgs e)
        {
            sysParams.getMemCommitedPerc();
            sysParams.getprocessorUtility();
            myVm.CPU = sysParams.processorUtility + "%";
            myVm.Mem = sysParams.MEMCommitedPerc + "%";
        }
    }

}
