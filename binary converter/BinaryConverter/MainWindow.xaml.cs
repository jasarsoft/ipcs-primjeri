using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BinaryConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int number;
            if (!Int32.TryParse(textBox1.Text, out number))
            {
                MessageBox.Show("TextBox does not contain an integer");
                return;
            }
                
            if(number <= 0)
            {
                MessageBox.Show("Please enter a positive number or zero");
                return;
            }

            int reminder = 0;
            StringBuilder binary = new StringBuilder();

            do
            {
                reminder = number % 2;
                number /= 2;
                binary.Insert(0, reminder);
            } while (number > 0);

            label1.Content = binary.ToString();
            
        }
    }
}
