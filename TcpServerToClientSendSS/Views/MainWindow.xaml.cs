using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;
using TcpServerToClientSendSS.AddditionalClasses;
using TcpServerToClientSendSS.ViewModels;
namespace TcpServerToClientSendSS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ScreenShot screenShot = new ScreenShot();
        public DateTime firstTime { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            App.MainViewModel = new MainViewModel();
            DataContext = App.MainViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
