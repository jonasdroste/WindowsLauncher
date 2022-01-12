using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace WindowsLauncher.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            ApplicationName = "Hello Wordl";
            ChangeApplicationNameCommand = new AsyncRelayCommand(ChangeApplicationName);
        }

        private string? applicationName;

        public string? ApplicationName
        {
            get { return applicationName; }
            set => SetProperty(ref applicationName, value);  
        }

        public IAsyncRelayCommand ChangeApplicationNameCommand { get; }

        private Task<string> ChangeApplicationName()
        {
            return Task.Run(() => ApplicationName ="Changed Application Name");
        }

    }
}
