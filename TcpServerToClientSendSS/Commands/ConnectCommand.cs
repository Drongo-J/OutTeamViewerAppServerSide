using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TcpServerToClientSendSS.AddditionalClasses;
using TcpServerToClientSendSS.ViewModels;

namespace TcpServerToClientSendSS.Commands
{
    public class ConnectCommand : ICommand
    {
        public ConnectCommand(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged;
        public MainViewModel MainViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            Network network = new Network();
            Task.Run(() => {
                network.StartTcpServer();
            }
            );

        }
    }
}
