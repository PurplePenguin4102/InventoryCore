using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueForCompletion { get; set; } 
        public virtual List<Possession> StuffRequired { get; set; }
        public virtual List<OwnerTodos> PeopleAssigned { get; set; }
        public bool IsComplete { get; set; }
    }
}
