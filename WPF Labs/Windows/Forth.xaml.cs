using System.ComponentModel;
using System.Windows;

namespace WPF_Labs.Windows
{
    public partial class Forth : Window
    {
        public Forth()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Visibility = Visibility.Hidden;
            e.Cancel = true;
        }
        
        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            if (Calendar.SelectedDate != null && Calendar.SelectedDate.Value.Date.ToShortDateString() == TextBox.Text)
            {
                MessageBox.Show("Correct date");
            }
        
        }
    }
}