using System;
using System.Collections.Generic;
using System.Linq;
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


namespace Gusev_ITMO_WPF_Final_Exercise
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            Key number = e.Key;
            if (e.Key != Key.Delete && e.Key != Key.Back && e.Key != Key.Enter && e.Key != Key.NumLock
                 && e.Key != Key.Decimal
                 && e.Key != Key.NumPad0 && e.Key != Key.NumPad1 && e.Key != Key.NumPad2 && e.Key != Key.NumPad3 && e.Key != Key.NumPad4
                 && e.Key != Key.NumPad5 && e.Key != Key.NumPad6 && e.Key != Key.NumPad7 && e.Key != Key.NumPad8 && e.Key != Key.NumPad9
                 ) //калькулятор
            {
                e.Handled = true;
            }

        }

        private void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            Key number = e.Key;
            if (e.Key != Key.Delete && e.Key != Key.Back && e.Key != Key.Enter && e.Key != Key.NumLock
                 && e.Key != Key.Decimal
                 && e.Key != Key.NumPad0 && e.Key != Key.NumPad1 && e.Key != Key.NumPad2 && e.Key != Key.NumPad3 && e.Key != Key.NumPad4
                 && e.Key != Key.NumPad5 && e.Key != Key.NumPad6 && e.Key != Key.NumPad7 && e.Key != Key.NumPad8 && e.Key != Key.NumPad9
                 ) //калькулятор
            {
                e.Handled = true;
            }
            
        }
    }
}
