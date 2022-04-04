using MyWidget;
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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfWidgetDesktop.Utils;
using WpfWidgetDesktop.View.Widgets;

namespace WpfWidgetDesktop
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            SettingProvider.Load();
            InitializeComponent();

            int workWidth = (int)SystemParameters.WorkArea.Width;
            int workHeight = (int)SystemParameters.WorkArea.Height;
            this.Height = workHeight - 10;
            this.Left = workWidth - 635;
            this.Top = 5;

            this.ShowInTaskbar = false;

            //IntPtr hWnd = new WindowInteropHelper(GetWindow(this)).EnsureHandle();
            //MyWindowStyle.EnableBlur(hWnd);
            //MyWindowStyle.EnableRoundWindow(hWnd);


        }
        private string GetNow()
        {
            int a = DateTime.Now.Hour;
            if (a < 6)
            {
                return "夜深了,";
            }
            else if (a < 12)
            {
                return "早上好,";
            }
            else if (a < 13) { return "中午好,"; }
            else if (a < 18)
            {
                return "下午好,";
            }
            else
            {
                return "晚上好,";
            }
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            hello.Text = $"{GetNow()}{System.Environment.UserName}";
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            if (WindowState != WindowState.Minimized)
            {
                WindowState = WindowState.Minimized;
            }

        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                this.ShowInTaskbar = true;
            }
            else
            {
                this.ShowInTaskbar = false; 
            }

        }
    }
}
