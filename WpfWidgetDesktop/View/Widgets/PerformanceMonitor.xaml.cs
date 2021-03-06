using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfWidgetDesktop.ViewModel;

namespace WpfWidgetDesktop.View.Widgets
{
    /// <summary>
    /// PerformanceMonitor.xaml 的交互逻辑
    /// </summary>
    public partial class PerformanceMonitor : UserControl
    {
        public PerformanceMonitor()
        {
            InitializeComponent();
            this.DataContext = new PerformanceMonitorVM();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new LayerWindow(new PerformanceMonitor()).Show();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.Parent.GetType() != typeof(Util.Panels.TilePanel))
            {
                root.ContextMenu = null;
            }
        }
    }
}
