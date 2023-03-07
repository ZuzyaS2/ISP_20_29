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
using System.Windows.Shapes;

namespace ISP_20_29
{
    /// <summary>
    /// Логика взаимодействия для register.xaml
    /// </summary>
    public partial class register : Window
    {
        public register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
      
        private void sohr_Click(object sender, RoutedEventArgs e)

        {
            string command = $@"INSERT INTO [dbo].[User]
             ([UserSurname]
             ,[UserName]
             ,[UserPatronymic]
             ,[UserLogin]
             ,[UserPassword]
             ,[UserRole])
     VALUES
             ('{Name.Text}'
             ,'{Familya.Text}'
             ,'{Otchestvo.Text}'
             ,'{Login2.Text}'
             ,'{Password2.Text}'
             ,3)";
                  new SQL().InsDelUpd(command);
        }
        else
        
    }
}
