using System.Windows;

namespace WPF_Labs
{
    public class Student : DependencyObject
    {
        private static readonly DependencyProperty FirstNameProperty;
        private static readonly DependencyProperty LastNameProperty;
        private static readonly DependencyProperty CourseProperty;

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

        public int Course
        {
            get => (int) GetValue(CourseProperty);
            set => SetValue(CourseProperty, value);
        }

        static Student()
        {
            FirstNameProperty = DependencyProperty.Register(nameof(FirstName), typeof(string), typeof(Student));
            LastNameProperty = DependencyProperty.Register(nameof(LastName), typeof(string), typeof(Student));
            CourseProperty = DependencyProperty.Register(nameof(Course), typeof(int), typeof(Student));
        }
    }
}