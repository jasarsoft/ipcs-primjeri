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

namespace SimpleTextEditor
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

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text document (.txt)|*.txt";
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string fileName = dlg.FileName;
                tbEditor.Text = System.IO.File.ReadAllText(fileName);
            }
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.DefaultExt = ".txt";
            dialog.Filter = "Text document (.txt)|*.txt";
            Nullable<bool> result = dialog.ShowDialog();
            if (result == true)
            {
                string fileName = dialog.FileName;
                System.IO.File.WriteAllText(fileName, tbEditor.Text);
            }
        }
    }
}
