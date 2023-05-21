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

namespace wpfZadanie1.Vive
{
    /// <summary>
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            MainFrame.Content = new LogIN();
        }
        private void Button_Click_LogIn(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new LogIN();
            Brush colorTrue = new SolidColorBrush(Color.FromRgb(210, 210, 210));
            Brush colorFalse = new SolidColorBrush(Color.FromRgb(134, 134, 134));
            ButtonLogIn.Foreground = colorTrue;
            ButtonSingUp.Foreground = colorFalse;

        }

        private void Button_Click_SingUP(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new SingUp();
            Brush colorTrue = new SolidColorBrush(Color.FromRgb(210, 210, 210));
            Brush colorFalse = new SolidColorBrush(Color.FromRgb(134, 134, 134));
            ButtonLogIn.Foreground = colorFalse;
            ButtonSingUp.Foreground = colorTrue;
        }

    }
}
