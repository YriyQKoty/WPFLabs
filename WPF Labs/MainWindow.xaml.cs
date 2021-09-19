using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPF_Labs.Windows;

namespace WPF_Labs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
       private First _firstWin;
       private Second _secondWin;
       private Third _thirdWin;
       private Forth _forthWin;
       
        public MainWindow()
        {
            InitializeComponent();

            _firstWin = new First();
            _secondWin = new Second();
            _thirdWin = new Third();
            _forthWin = new Forth();
        }

        private void Btn1_OnClick(object sender, RoutedEventArgs e)
        {
            _firstWin.Show();
        }

        private void Btn2_OnClick(object sender, RoutedEventArgs e)
        {
           _secondWin.Show();
        }

        private void Btn3_OnClick(object sender, RoutedEventArgs e)
        {
           _thirdWin.Show();
        }

        private void Btn4_OnClick(object sender, RoutedEventArgs e)
        {
            _forthWin.Show();
        }
    }
}