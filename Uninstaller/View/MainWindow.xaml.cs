using Uninstaller.ViewModels;
using System.Windows;
using System.Windows.Controls;
using Ninject;
using System.Reflection;

namespace Uninstaller
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var viewModel = kernel.Get<MainViewModel>();
            DataContext = viewModel.Model;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void TaskbarIcon_TrayLeftMouseDown(object sender, RoutedEventArgs e)
        {
            this.Show();
        }
    }
}
