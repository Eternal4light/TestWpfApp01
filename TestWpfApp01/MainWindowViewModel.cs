using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using  System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace TestWpfApp01
{
   public partial class MainWindowViewModel : BaseViewModel 
    { 
        private readonly Interface01 _service;

        private string _synchronizedText;
        public string SynchronizedText
        {
            get => _synchronizedText;
            set
            {
                _synchronizedText = value;
                OnPropertyChanged(nameof(SynchronizedText));
            }
        }



       private ObservableCollection<string> _theList;
       public ObservableCollection<string> TheList
        {
            get => _theList;
            set
            {
                _theList = value;
                OnPropertyChanged(nameof(TheList));
            }
       }


        //DIP/OCP
        public MainWindowViewModel(Interface01 service)
        {
            _service = service;
            SynchronizedText = "123";
           TheList = new ObservableCollection<string> { "123", "abc", "0_0" };
            
        }

       
        private RelayCommand addGuid;
        public  RelayCommand AddGuid
        {
           get { return addGuid ?? (addGuid = new RelayCommand(obj => { TheList.Add(_service.GetGuid()); }));
            }
        }
        
        
        
    }
}
