using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WPF_Labs
{
    public partial class Second : Window
    {
        private Human _student = new Human() {Age = 18, FirstName = "Test", LastName = "test"};

        public Human Human => _student;
        
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
        }

        public Second()
        {
            InitializeComponent();
        }
        
    }
}