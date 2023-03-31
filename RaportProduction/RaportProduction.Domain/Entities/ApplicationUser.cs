using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaportProduction.Domain.Entities
{
    public class ApplicationUser
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public DateTime RegisterDataTime { get; set; }
        public bool IsDeleted { get; set; }

        public Address Address { get; set; }
        public Employee Employee { get; set; }
        public ICollection<Raport> Raports { get; set; } = new HashSet<Raport>();
        public ICollection<EmployeeEvent> EmployeeEvents { get; set; } = new HashSet<EmployeeEvent>();
    }

}
