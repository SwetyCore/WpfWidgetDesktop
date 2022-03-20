using MyWidget2.Utils;
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
using WpfWidgetDesktop.Utils;

namespace WpfWidgetDesktop.View.Widgets
{
    /// <summary>
    /// UserControl2.xaml 的交互逻辑
    /// </summary>
    public partial class ShortcutSwitch : UserControl
    {
        public ShortcutSwitch()
        {

            InitializeComponent();
            slider.Value = double.Parse(BasicMethods.GetBrightness());
        }

        private void root_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.Parent.GetType() != typeof(Util.Panels.TilePanel))
            {
                root.ContextMenu = null;
            }

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new LayerWindow(new ShortcutSwitch()).Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = MessageBox.Show("确认关机?","提示", MessageBoxButton.OKCancel);
            if (a == MessageBoxResult.OK)
            {
                BasicMethods.runcmd("shutdown -p");

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BasicMethods.runcmd("rundll32.exe user32.dll LockWorkStation");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BasicMethods.runcmd("start ms-settings:wheel");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            BasicMethods.runcmd("start https://snapdrop.net");
        }



        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            BasicMethods.SetBrightness(int.Parse(slider.Value.ToString()));
        }
    }
}
