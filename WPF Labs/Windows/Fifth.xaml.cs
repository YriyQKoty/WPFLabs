using System.ComponentModel;
using System.Windows;

namespace WPF_Labs.Windows
{
    public partial class Fifth : Window
    {
        public Fifth()
        {
            InitializeComponent();
        }
        
        protected override void OnClosing(CancelEventArgs e)
        {
            Visibility = Visibility.Hidden;
            e.Cancel = true;
        }
    }
}