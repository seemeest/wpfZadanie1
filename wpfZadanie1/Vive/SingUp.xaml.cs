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
using MySql.Data.MySqlClient;

namespace wpfZadanie1
{
    /// <summary>
    /// Логика взаимодействия для SingUp.xaml
    /// </summary>
    public partial class SingUp : Page
    {
        string connStr = "server=127.0.0.1;user=root;database=zadanie4;";
        public SingUp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if(_CheckBox.IsChecked == false) { MessageBox.Show("Согласитесь с правивалми"); return; }
            
            if (password1.Password != password2.Password) { MessageBox.Show("Пароли не совпадают"); return;}
            if (password1.Password == string.Empty || password2.Password == string.Empty) { MessageBox.Show("Пароли пусты"); return; }
            if (EmailBox.Text == string.Empty) { MessageBox.Show("Email пуст"); return; }
            if (LoginBox.Text == string.Empty) { MessageBox.Show("Login пуст"); return; }

            string login = LoginBox.Text;
            string email=EmailBox.Text;
            string password=password1.Password;

            // не  доделал 
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = $"INSERT INTO `_users`(`login`, `password`, `Email`) VALUES ('{login}','{password}','{email}')";
            MySqlCommand command = new MySqlCommand(sql,conn);
             
        }
    }
}
