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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var back = new MainWindow();
            this.Close();
            back.Show();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text == string.Empty)
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            else
            {
                var go = new main();
                this.Close();
                go.Show();
            }

            if (login.Text=="admin" && password.Password=="admin" )
            {
                var go = new admin();
                this.Close();
                go.Show();
            }
        }
    }
}
