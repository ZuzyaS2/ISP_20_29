using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace ISP_20_29
{
    /// <summary>
    /// Логика взаимодействия для Almin.xaml
    /// </summary>
    public partial class Almin : Window
    {
        public Almin()
        {
            InitializeComponent();
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clients.Children.Clear();
            SqlDataReader reader = new SQL().Select(@"SELECT
                                     [UserID],
                                     [UserSurname]
                                    ,[UserName]
                                    ,[UserPatronymic]
                                   FROM [Trade].[dbo].[User]");
            while (reader.Read())
            {
                Client client = new Client();
                client.Fio.Content = reader[1].ToString();
                client.DateofBrith.Content = reader[2].ToString();
                client.City.Content = reader[3].ToString();
                client.UserID = reader[0].ToString();
                Clients.Children.Add(client);
            }
        }
    }
}
