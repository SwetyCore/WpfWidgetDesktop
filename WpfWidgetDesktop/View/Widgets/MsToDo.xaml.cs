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
    /// MsToDo.xaml 的交互逻辑
    /// </summary>
    public partial class MsToDo : UserControl
    {
        MsTodoViewModel _todoViewModel;
        public MsToDo()
        {
            InitializeComponent();
            _todoViewModel = new MsTodoViewModel();
            this.DataContext = _todoViewModel;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _todoViewModel.GetTasksAsync(
            ((Microsoft.Graph.Entity)((object[])e.AddedItems)[0]).Id.ToString());

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

            new LayerWindow(new MsToDo()).Show();
        }

        private void CloseFlyOut(object sender, RoutedEventArgs e)
        {

            Flyout f = FlyoutService.GetFlyout(AddBtn) as Flyout;
            if (f != null)
            {
                f.Hide();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_todoViewModel.selectedTaskListId == null)
            {
                MessageBox.Show("请先选择一个列表!");
            }

            _todoViewModel.Create();

            Flyout f = FlyoutService.GetFlyout(AddBtn) as Flyout;
            if (f != null)
            {
                f.Hide();
            }
        }
    }
}
