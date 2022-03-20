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
using Util.Panels;

namespace WpfWidgetDesktop.View.Widgets
{
    /// <summary>
    /// Album.xaml 的交互逻辑
    /// </summary>
    public partial class Album : UserControl
    {
        public Album()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new LayerWindow(new Album()).Show();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.Parent.GetType()!=typeof(TilePanel))
            {
                root.ContextMenu = null;
            }

        }
    }
}
