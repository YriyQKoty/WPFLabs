using System;
using System.Linq;
using System.Windows;

namespace WPF_Labs
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

        private void Btn1_OnClick(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(TextBox1.Text, out int num))
            {
                MessageBox.Show(  num % 2 == 0 ? "Number is Even" : "Number is Odd");
            }
            else
            {
                MessageBox.Show("'A' character count in text: " + TextBox1.Text.ToLower().Count(c => c == 'a'));
            }
           
        }
    }
}