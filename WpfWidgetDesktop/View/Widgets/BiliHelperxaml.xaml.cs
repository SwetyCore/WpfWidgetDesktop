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
    /// BiliHelperxaml.xaml 的交互逻辑
    /// </summary>
    public partial class BiliHelperxaml : UserControl
    {
        BiliVM vm=new BiliVM();
        public BiliHelperxaml()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            new LayerWindow(new BiliHelperxaml()).Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //vm.GetUserInfo();
            vm.GetCard();

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.Parent.GetType() != typeof(Util.Panels.TilePanel))
            {
                root.ContextMenu = null;
            }

            vm.GetCard(false);
        }

        private void SaveBtn(object sender, RoutedEventArgs e)
        {
            if (vm.myVm.Cookie == ""|vm.myVm.Cookie==null)
            {
                MessageBox.Show("Cookie不能为空!");
                return;
            }
            vm.Save();
        }
    }
}
