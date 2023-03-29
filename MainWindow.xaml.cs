using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace Bloknot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string opendFile = "";
        private string text;
        public MainWindow()
        {
            InitializeComponent();
            //textBox.TextWrapping= TextWrapping.NoWrap;
        }
        public MainWindow(bool wrap , string text , int size)
        {
            InitializeComponent();
            if (wrap)
            {
                textBox.TextWrapping = TextWrapping.Wrap;
            }
            else
            {
                textBox.TextWrapping = TextWrapping.NoWrap;
            }
            textBox.Text = text;
            textBox.FontSize= size;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == true)
            {
                opendFile = openFileDialog.FileName;
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    textBox.Text = reader.ReadToEnd();
                }
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == true)
            {
                opendFile = sfd.FileName;
                //seveFile(sfd.FileName);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1(textBox.Text);
            window1.ShowDialog();
            this.Close();
        }
    }
}
