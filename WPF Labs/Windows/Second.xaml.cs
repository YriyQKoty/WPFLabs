using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace WPF_Labs.Windows
{
    public partial class Second : Window
    {
        private List<CheckBox> _checkBoxes = new List<CheckBox>();
        public Second()
        {
            InitializeComponent();
            
            _checkBoxes.AddRange(new []{CheckBox1, CheckBox2, CheckBox3});
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
        }


        private void Btn1_OnClick(object sender, RoutedEventArgs e)
        {
            var listItem = (ListBoxItem) MyListBox.SelectedItem;

            var result = "";
            var checkedBoxes = _checkBoxes.Where(c => c.IsChecked == true);
            foreach (var cb in checkedBoxes)
            {
                if (cb == CheckBox1)
                {
                    result += " Yuriy";
                }
                else if (cb == CheckBox2)
                {
                    result += " Afonin";
                }
                else if (cb == CheckBox3)
                {
                    result += " Sergiyovych";
                }
            }
        
            MessageBox.Show(listItem?.Content + result);
        }
    }
}