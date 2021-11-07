using System.ComponentModel;
using System.Runtime.CompilerServices;
using WPF_Labs.Annotations;

namespace WPF_Labs
{
    public class Product : INotifyPropertyChanged
    {
        private string _title;
        private string _company;
        private int _price;
        
        
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }
        public string Company
        {
            get { return _company; }
            set
            {
                _company = value;
                OnPropertyChanged("Company");
            }
        }
        public int Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged("Price");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}