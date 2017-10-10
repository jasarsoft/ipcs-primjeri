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

namespace GCDEuclid
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

        private void btn2Int_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = int.Parse(tbInt1.Text);
            int secondNumber = int.Parse(tbInt2.Text);
            this.lblResult.Content = String.Format("Euclid: {0}", GDCAlgorithams.FindGCDEuclid(firstNumber, secondNumber));
        }

        private void btn3Int_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = int.Parse(tbInt1.Text);
            int secondNumber = int.Parse(tbInt2.Text);
            int thirdNumber = int.Parse(tbInt3.Text);
            this.lblResult.Content = String.Format("Euclid: {0}", GDCAlgorithams.FindGCDEuclid(firstNumber, secondNumber, thirdNumber));
        }

        private void btn4Int_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = int.Parse(tbInt1.Text);
            int secondNumber = int.Parse(tbInt2.Text);
            int thirdNumber = int.Parse(tbInt3.Text);
            int fourNumber = int.Parse(tbInt4.Text);
            this.lblResult.Content = String.Format("Euclid: {0}", GDCAlgorithams.FindGCDEuclid(firstNumber, secondNumber, thirdNumber, fourNumber));
        }

        private void btn5Int_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(tbInt1.Text);
            int num2 = int.Parse(tbInt2.Text);
            int num3 = int.Parse(tbInt3.Text);
            int num4 = int.Parse(tbInt4.Text);
            int num5 = int.Parse(tbInt5.Text);
            lblResult.Content = String.Format("Euclid: {0}", GDCAlgorithams.FindGCDEuclid(num1, num2, num3, num4, num5));
        }
    }
}
