using System.Windows;
using System.Windows.Controls;


namespace vjezba01
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

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(((ComboBoxItem)comboBox.SelectedItem).Content.ToString());
        }
    }
}
