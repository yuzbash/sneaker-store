using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
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
    /// Логика взаимодействия для main.xaml
    /// </summary>
    public partial class main : Window
    {
        
            
        public main()
        {
            InitializeComponent();
            string[] str = File.ReadAllLines("cross.txt");
            this.one.Text = str[0]+str[1]+str[2]+str[3];
            this.two.Text = str[4]+str[5]+str[6]+str[7];
            this.three.Text = str[8]+str[9]+str[10]+str[11];
            this.four.Text = str[12]+str[13]+str[14]+str[15]; 
            this.five.Text = str[16]+str[17]+str[18]+str[19];
            //this.six.Text = str[20]+ "/n" +str[21]+ "/n" +str[22]+ "/n" +str[23];

           

        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sneak = new xiii();
            this.Close();
            sneak.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var sneak = new ij();
            this.Close();
            sneak.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var sneak = new red();
            this.Close();
            sneak.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var sneak = new iiii();
            this.Close();
            sneak.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var sneak = new moc();
            this.Close();
            sneak.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var sneak = new jan();
            this.Close();
            sneak.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            StreamReader str = new StreamReader("cross.txt", Encoding.Default);
            while (!str.EndOfStream)
            {
                string st = str.ReadLine();
                if (st.StartsWith(find.Text))
                {
                    info.Items.Add(st.ToString());
                    break;
                }
            }
        }

        private void one_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }

        private void info_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
