using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace WPF_Labs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Circle!");
        }

        private void UIElement_OnKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show($"Key {e.Key} was pressed");
        }

        private void FrameworkElement_OnLoaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Element was loaded!");
            KeyDown += UIElement_OnKeyDown;
        }

        private void UIElement_OnGotFocus(object sender, RoutedEventArgs e)
        {
            TextBox1.Focus();
            MessageBox.Show("Got focus)");
        }

        private void UIElement_OnLostFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Lost focus(");
        }
    }
}