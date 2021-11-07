using System.Windows;

namespace WPF_Labs
{
    public class Human : DependencyObject
    {
        private static readonly DependencyProperty FirstNameProperty;
        private static readonly DependencyProperty LastNameProperty;
        private static readonly DependencyProperty AgeProperty;

        public string FirstName
        {
            get => (string) GetValue(FirstNameProperty);
            set => SetValue(FirstNameProperty, value);
        }
        
        public string LastName
        {
            get => (string) GetValue(LastNameProperty);
            set => SetValue(LastNameProperty, value);
        }
        
        public int Age
        {
            get => (int) GetValue(AgeProperty);
            set => SetValue(AgeProperty, value);
        }

        static Human()
        {
            FirstNameProperty = DependencyProperty.Register(nameof(FirstName), typeof(string), typeof(Human));
            LastNameProperty = DependencyProperty.Register(nameof(LastName), typeof(string), typeof(Human));
            AgeProperty = DependencyProperty.Register(nameof(Age), typeof(int), typeof(Human));
        }
    }
}