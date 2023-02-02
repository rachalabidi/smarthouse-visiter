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
using System.Windows.Shapes;

namespace GTS
{
    /// <summary>
    /// Logique d'interaction pour demandeAcces.xaml
    /// </summary>
    public partial class demandeAcces : Window
    {
        public demandeAcces()
        {
            InitializeComponent();
        }
       
       

        private string GeneratePassword()
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            char[] password = new char[8];
            Random random = new Random();

            for (int i = 0; i < password.Length; i++)
            {
                password[i] = validChars[random.Next(validChars.Length)];
            }

            return new string(password);
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            string password = GeneratePassword();
            PasswordTextBlock.Text = password;
        }

       

        private void RepeatButton_Click_1(object sender, RoutedEventArgs e)
        {
            string password = PasswordTextBlock.Text;
            string enteredPassword = pass.Password;

            if (password == enteredPassword)
            {
                MessageBox.Show("DOOR OPENED.");
                String time = GetTimestamp(DateTime.Now);
                string myslqcon = "server=localhost;user=root;database=smarthouse;password=";
                MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);
                try
                {
                    mySqlConnection.Open();
                    Console.Write("odne");
                    string sql = "INSERT INTO `door`(`time`, `open`, `person`) VALUES (@id,@Username,@p  );";
                    MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                    _ = mySqlCommand.Parameters.AddWithValue("@id", time);
                    _ = mySqlCommand.Parameters.AddWithValue("@Username", "1");
                    _ = mySqlCommand.Parameters.AddWithValue("@p", "visiteur");

                    mySqlCommand.Prepare();
                    Console.Write("debug here  ___________");
                    _ = mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                }
                catch (MySqlException ex)
                {
                    Console.Write("ERR hna ", ex);
                }
            }
            else
            {
                MessageBox.Show("PLEASE TRY AGAIN .");
            }
        }
        private string GetTimestamp(DateTime value)
        {
            return value.ToString("MM dd HH mm ");

        }
    }
}
