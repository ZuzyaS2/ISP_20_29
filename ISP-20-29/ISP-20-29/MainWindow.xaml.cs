using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace ISP_20_29
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Login1_Click(object sender, RoutedEventArgs e)
        {
            SqlDataReader reader = new SQL().Select($@"SELECT * FROM [Trade]. [dbo].[User]

                where UserLogin = '{login.Text}' and UserPassword = '{password.Password}'");

            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    MessageBox.Show("С возращением \n" + reader[1]);
                    if (reader[6].ToString() == "1")
                    {
                        Almin almin = new Almin();
                        almin.ShowDialog();
                    }
                    else if (reader[6].ToString() == "2")
                    {
                        skskkssk skskkssk = new skskkssk();
                        skskkssk.ShowDialog();
                    }
                    else if (reader[6].ToString() == "3")
                    {
                        user user = new user();
                        user.ShowDialog();
                    }

                }

            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            register register = new register();
            register.ShowDialog();
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
