using System;
using System.ComponentModel;
using System.Windows;

namespace WPF_Labs.Windows
{
    public partial class Third : Window
    {
        private double _initialFirstImageWidth;
        private double _initialSecondImageWidth;
        public Third()
        {
            InitializeComponent();

            _initialFirstImageWidth = img1.Width;
            _initialSecondImageWidth = img2.Width;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Visibility = Visibility.Hidden;
            e.Cancel = true;
        }

        private void Slider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (cmbox.SelectedIndex == 0)
            {
                img1.Width = (Slider.Value / 100)* _initialFirstImageWidth;
            }
            else if (cmbox.SelectedIndex == 1)
            {
                img2.Width = (Slider.Value / 100) * _initialSecondImageWidth;
            }

        }
    }
}