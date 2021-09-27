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
        private Student _student = new Student() {Course = 1, FirstName = "Test", LastName = "test"};

        public Student Student => _student;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Check_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{Student.Course}, {Student.FirstName}, {Student.LastName}");
        }
    }
}