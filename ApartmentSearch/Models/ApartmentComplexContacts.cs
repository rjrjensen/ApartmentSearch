using System;
using System.Collections.Generic;

namespace ApartmentSearch.Models
{
    public partial class ApartmentComplexContacts
    {
        public ApartmentComplexContacts()
        {
            ApartmentComplexes = new HashSet<ApartmentComplexes>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<ApartmentComplexes> ApartmentComplexes { get; set; }
    }
}
