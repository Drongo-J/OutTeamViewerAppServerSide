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
        private void DispatcherTimerForDeleting_Tick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                for (int i3 = i2; i3 < i; i3++)
                {
                    File.Delete(@"C:\Users\Documents\source\repos\TspClientToServerSnedSS\TcpServerToClientSendSS\bin\Debug\" + "screenshot" + i3.ToString() + ".png");
                }
                i2 = i;
            });

        }

        int i = 0;
        int i2 = 0;
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            // if (i >= 4)
            //{
            //if(File.Exists(@"C:\Users\Jama_yw17\source\repos\TcpServerToClientSendSS\TcpServerToClientSendSS\bin\Debug\" + "screenshot" + (i - 2).ToString() + ".png"))
            //{

            //File.Delete(@"C:\Users\Jama_yw17\source\repos\TcpServerToClientSendSS\TcpServerToClientSendSS\bin\Debug\" + "screenshot" + (i-2).ToString() + ".png");
            //}
            //}
            Task.Run(() =>
            {
                App.MainViewModel.Source = screenShot.TakeScreenShot(i++);

            });
            App.MainViewModel.Timer = (firstTime - DateTime.Now).ToString();
        }
    }
}
