using Inventory.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Inventory.Domain.Enums;

namespace Inenvory.UI
{
    public class MainPageModel
    {
        public ObservableCollection<Owner> OwnerList { get; set; }

        public MainPageModel()
        {
            if (DesignMode.DesignModeEnabled)
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
                        Birthday = new DateTime(1987, 07, 20)
                    },
                    new Owner
                    {
                        FirstName = "Wolfcat",
                        LastName = "Mozart",
                        Gender = Gender.Male,
                        Type = OwnerTypes.Cat,
                        Birthday = new DateTime(1987, 07, 20)
                    }

                };
            }
        }
    }
}
