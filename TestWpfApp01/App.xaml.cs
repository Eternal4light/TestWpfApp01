using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Ninject;

namespace TestWpfApp01
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private StandardKernel _kernel;

        protected override void OnStartup(StartupEventArgs e)
        {




            


            //LSP - SOLID
            base.OnStartup(e);

            ConfigureContainer();

            App.Current.MainWindow = _kernel.Get<MainWindow>();
            App.Current.MainWindow.Show();


        }

        private void ConfigureContainer()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<Interface01>().To<Service>();
            // _kernel.Bind<IGetOne>().To<Service2>();
        }


    }
}



///При нажатии Start должна появляться единичка
///менять можно только этот файл
///можно создавать новые файлы
