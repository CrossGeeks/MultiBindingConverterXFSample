using System;
using System.Globalization;
using Xamarin.Forms;

namespace BindableConverterSample
{
    public class MultiBindingToColorConverter : IMultiValueConverter
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private bool IsAdmin { get; set; }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values != null)
            {
                foreach (var value in values)
                {
                    if(value is int age)
                    {
                        Age = age;
                    }

                    if (value is bool isAdmin)
                    {
                        IsAdmin = isAdmin;
                    }

                    if (value is string name)
                    {
                        Name = name;
                    }
                }

                if(string.IsNullOrEmpty(Name))
                {
                    return Color.Black;
                }    

                if(Age >= 18 && !IsAdmin)
                {
                    return Color.Red;
                }else if (Age < 18 && !IsAdmin)
                {
                    return Color.Blue;
                }
                else if (Age < 18 && IsAdmin)
                {
                    return Color.Green;
                }
                else if (Age >= 18 && IsAdmin)
                {
                    return Color.Fuchsia;
                }
            }

           return Color.Black;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => targetTypes;
    }
}