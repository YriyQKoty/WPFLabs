using System.ComponentModel;
using System.Windows;

namespace WPF_Labs.Windows
{
    public partial class Third : Window
    {
        public Third()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Product phone = (Product)this.Resources["product"];
            phone.Company = "Levengarden"; 
        }
    }
}