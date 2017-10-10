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

namespace SquareRoots
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Double numberDouble;
            if (!Double.TryParse(textBox1.Text, out numberDouble))
            {
                MessageBox.Show("Please enter valid number");
                return;
            }

            if (numberDouble < 0)
            {
                MessageBox.Show("Please enter positive number");
                return;
            }

            double squareRoot = Math.Sqrt(numberDouble);
            label1.Content = String.Format("{0} (Using .NET Framework)", squareRoot);

            Decimal numberDecimal;
            if (!Decimal.TryParse(textBox1.Text, out numberDecimal))
            {
                MessageBox.Show("Please enter valid decimal number");
                return;
            }

            Decimal delta = Convert.ToDecimal(Math.Pow(10, -28));
            Decimal guess = 2M;
            Decimal result = ((numberDecimal / guess) + guess) / 2;
            while (Math.Abs(result - guess) > delta)
            {
                guess = result;
                result = ((numberDecimal / guess) + guess) / 2;
            }

            label2.Content = String.Format("{0} (Using Newton)", result);
        }
    }
}
