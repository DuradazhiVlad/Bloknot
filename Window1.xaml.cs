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

namespace Bloknot
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string textTmp;
        int fontSize;
        public Window1(string text)
        {
            InitializeComponent();
            checkBox.IsChecked = true;
             textTmp=text;
        }

        

        private void checkBox_Click(object sender, RoutedEventArgs e)
        {
            
            if (checkBox.IsChecked == true)
            {
                checkBox.Content = "Обгортання тексту включено";                
            }
            if (checkBox.IsChecked == false)
            {
                checkBox.Content = "Обгортання тексту виключено";                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool isWrapChecked = checkBox.IsChecked == true;
            MainWindow mainWindow = new MainWindow(isWrapChecked, textTmp, fontSize);
            mainWindow.Show();
            this.Close();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            fontSize = 5;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            fontSize = 9;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            fontSize = 12;
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            fontSize = 15;
        }

        private void RadioButton_Click_4(object sender, RoutedEventArgs e)
        {
            fontSize = 25;
        }
    }
}
