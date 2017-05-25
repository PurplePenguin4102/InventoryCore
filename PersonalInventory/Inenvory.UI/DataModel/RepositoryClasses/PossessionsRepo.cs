using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DataModel.RepositoryClasses
{
    public class PossessionsRepo
    {
        private InventoryContext _db;

        internal PossessionsRepo(InventoryContext database)
        {
            _db = database;
        }

    }
}
