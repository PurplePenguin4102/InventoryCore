using Inventory.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Inventory.Domain.Enums;

namespace Inventory.UI
{
    public class MainPageModel
    {
        public ObservableCollection<Owner> OwnerList { get; set; }

        #region SelectedOwner
        private Owner _SelectedOwner;
        public Owner SelectedOwner
        {
            get => _SelectedOwner;
            set => _SelectedOwner = value;
        }
        #endregion

        public MainPageModel()
        {
            if (!DesignMode.DesignModeEnabled)
            {
            }
            else
            {
                OwnerList = new ObservableCollection<Owner>
                {
                    new Owner
                    {
                        FirstName = "Joey",
                        LastName = "Ray",
                        Gender = Gender.Male,
                        Type = OwnerTypes.Human,
                        Birthday = new DateTime(1987, 07, 20)
                    },
                    new Owner
                    {
                        FirstName = "Kate",
                        LastName = "Tillack",
                        Gender = Gender.Female,
                        Type = OwnerTypes.Human,
                        Birthday = new DateTime(1993, 05, 31)
                    },
                    new Owner
                    {
                        FirstName = "Wolfcat",
                        LastName = "Mozart",
                        Gender = Gender.Male,
                        Type = OwnerTypes.Cat,
                        Birthday = new DateTime(2015, 03, 15)
                    },
                    new Owner
                    {
                        FirstName = "Phryne",
                        LastName = "Fish-Eater",
                        Gender = Gender.Female,
                        Type = OwnerTypes.Cat,
                        Birthday = new DateTime(2015, 03, 15)
                    }
                };
            }
        }
    }

    public static class MyExtensions
    {

    }
}
