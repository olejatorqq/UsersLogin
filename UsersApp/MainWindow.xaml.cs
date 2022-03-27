using System;
using System.Windows;
using System.Windows.Media;

namespace UsersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassw.Password.Trim();
            string repassword = textBoxRePassw.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "Логин должен содержать более 5 символов";
                textBoxLogin.BorderBrush = Brushes.Red;
            }
            else if (password.Length < 5)
            {
                textBoxPassw.ToolTip = "Пароль должен содержать более 5 символов";
                textBoxPassw.BorderBrush = Brushes.Red;
            }
            else if (password != repassword)
            {
                textBoxRePassw.ToolTip = "Пароли не совпадают";
                textBoxRePassw.BorderBrush = Brushes.Red;
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Неправильно введена почта";
                textBoxEmail.BorderBrush = Brushes.Red;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                textBoxPassw.ToolTip = "";
                textBoxPassw.Background = Brushes.Transparent;
                textBoxRePassw.ToolTip = "";
                textBoxRePassw.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Успешно");
            }
        }
    }
}