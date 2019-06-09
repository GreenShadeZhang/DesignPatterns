using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IPChangedProject
{
  public  class Person:INotifyPropertyChanged
    {
        private string _xing;
        private string _ming;
        public string Xing { get { return _xing; } set { _xing = value;
                OnPropertyChanged();
                
            } }

        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Ming { get { return _ming; } set { _ming = value;
                OnPropertyChanged();
            } }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
