using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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


/// <summary>
/// 1. Два текстбокса, в верхний вводишь текст, в нижнем он появляется ОДНОВРЕМЕННО
/// 2. Раскрывающийся список, по нажатию кнопки в него вводится рандомная дичь GUID
/// </summary>


namespace TestWpfApp01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
            this.DataContext = new MainWindowViewModel();
           
            

           

        }
        
         

        





    }

}
