using MySql.Data.MySqlClient;
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

namespace wpfZadanie1
{
    /// <summary>
    /// Логика взаимодействия для LogIN.xaml
    /// </summary>
    public partial class LogIN : Page
    {
        public LogIN()
        {
            InitializeComponent();
        }
        string connStr = "server=127.0.0.1;user=root;database=zadanie4;";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_CheckBox.IsChecked == false) { MessageBox.Show("Согласитесь с правивалми"); return; }

            
            if (password1.Password == string.Empty ) { MessageBox.Show("Пароли пусты"); return; }
            if (LoginBox.Text == string.Empty) { MessageBox.Show("Login пуст"); return; }

            string login = LoginBox.Text;

            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string password = password1.Password;
            string sql = $" SELECT * FROM `_users` WHERE login = '{login}' AND password = '{password}'; ";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                // Авторизация успешна
                while (reader.Read())
                {
                    // Доступ к данным по авторизованному пользователю
                    string username = reader.GetString("login");

                }
            }
            else
            {
                MessageBox.Show("Ошибка авторизации");
            }

            // Закрытие ридера и соединения
            reader.Close();
            conn.Close();
        }
    }
}
