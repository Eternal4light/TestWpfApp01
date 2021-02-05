﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWpfApp01
{
   public class MainWindowViewModel : BaseViewModel
    {
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

        public MainWindowViewModel()
        {
            SynchronizedText = "123";
        }
    }
}