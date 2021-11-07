using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace WPF_Labs
{
    public partial class First : Window
    {
        public First()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
        }


        private void HelpCommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Help");
        }

        private void SelectCommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            txtBox.Focus();
            txtBox.SelectAll();
        }
    }
}