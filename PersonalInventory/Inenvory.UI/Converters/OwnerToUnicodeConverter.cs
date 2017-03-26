using Inventory.Domain;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Inventory.UI.Converters
{
    public class OwnerToUnicodeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Owner owner = (Owner)value;
            if (owner.Type == OwnerTypes.Cat)
            {
                return char.ConvertFromUtf32(0x0001F431).ToString();
            }
            else if (owner.Gender == Gender.Male)
            {
                return char.ConvertFromUtf32(0x0001F468).ToString();
            }
            else
                return char.ConvertFromUtf32(0x0001F469).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
