using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Labs.Windows
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


        private void Btn1_OnClick(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(TextBox.Text, out var num))
            {
                MessageBox.Show("Not a string!");
            }
            else
            {
                MessageBox.Show("String length " + TextBox.Text.Length);
            }
        }

        private void Btn2_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(TextBox.Text == "C#" ? "Correct!" : "Incorrect.");
        }

        private void Btn3_OnClick(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "Yuriy Afonin";
        }
    }
}