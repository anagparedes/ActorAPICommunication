using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WebServiceActorApi.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
