using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpServerToClientSendSS.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
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

    }
}
