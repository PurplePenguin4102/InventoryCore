using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.DataModel.RepositoryClasses;

namespace Inventory.DataModel
{
    public class Repository
    {
        public OwnersRepo OwnersRepo { get; }
        public PossessionsRepo PossessionsRepo { get; }

        private Repository()
        {
            InventoryContext ic = new InventoryContext();
            OwnersRepo = new OwnersRepo(ic);
            PossessionsRepo = new PossessionsRepo(ic);
        }

        private static Repository _Instance;
        public static Repository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Repository();
                }
                return _Instance;
            }
        }
    }
}
