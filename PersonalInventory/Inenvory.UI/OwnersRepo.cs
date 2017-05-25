using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DataModel.RepositoryClasses
{
    public class OwnersRepo
    {
        private InventoryContext _db;

        internal OwnersRepo(InventoryContext database)
        {
            _db = database;
        }

    }
}
