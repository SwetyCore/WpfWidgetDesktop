using ModernWpf.Controls;
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
    /// GenshinHelper.xaml 的交互逻辑
    /// </summary>
    public partial class GenshinHelper : UserControl
    {

        GenshinVM vm;
        public GenshinHelper()
        {
            InitializeComponent();
            vm = new GenshinVM();
            this.DataContext = vm;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            new LayerWindow(new GenshinHelper()).Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.Refresh();

            
        }

        private void root_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.Parent.GetType() != typeof(Util.Panels.TilePanel))
            {
                root.ContextMenu = null;
            }

        }

        private void Save_Change(object sender, RoutedEventArgs e)
        {
            vm.Save();
            Flyout f = FlyoutService.GetFlyout(SaveBtn) as Flyout;
            if (f != null)
            {
                f.Hide();
            }
        }
    }
}
