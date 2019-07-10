using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcpServerToClientSendSS.Commands;

namespace TcpServerToClientSendSS.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        public ConnectCommand ConnectCommand => new ConnectCommand(this);
        private string ipAddress;

        public string IpAddress
        {
            get
            {
                return ipAddress;
            }
            set
            {
                ipAddress = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(IpAddress)));
            }
        }

        private string source;

        public string Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Source)));
            }
        }
        private string timer;

        public string Timer
        {
            get { return timer; }
            set
            {
                timer = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Timer)));
            }
        }

    }
}
