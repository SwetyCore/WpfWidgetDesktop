using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Shapes;

namespace WpfWidgetDesktop
{
    /// <summary>
    /// LayerWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LayerWindow : Window
    {
        public LayerWindow(UserControl widget)
        {
            InitializeComponent();
            control.Children.Add(widget);
        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Activated(object sender, EventArgs e)
        {

            border.BorderThickness = new Thickness(1);
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            border.BorderThickness = new Thickness(0);
        }
    }
}
