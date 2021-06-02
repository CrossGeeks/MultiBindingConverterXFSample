using System.ComponentModel;

namespace BindableConverterSample
{
    public class MainPageViewModel: INotifyPropertyChanged
    {
        bool _isAdmin;
        public bool IsAdmin
        {
            set
            {
                if (_isAdmin != value)
                {
                    _isAdmin = value;
                    OnPropertyChanged("IsAdmin");
                }
            }
            get
            {
                return _isAdmin;
            }
        }

        int _customerAge = 20;
        public int Age
        {
            set
            {
                if (_customerAge != value)
                {
                    _customerAge = value;
                    OnPropertyChanged("Age");
                }
            }
            get
            {
                return _customerAge;
            }
        }

        string _name;
        public string Name
        {
            set
            {
                if (_name != value)
                {
                    _name = value;

                    OnPropertyChanged("Name");
                }
            }
            get
            {
                return _name;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
