using System;
using System.Collections.Generic;

namespace ApartmentSearch.Models
{
    public partial class ApartmentComplexAddresses
    {
        public ApartmentComplexAddresses()
        {
            ApartmentComplexes = new HashSet<ApartmentComplexes>();
        }

        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<ApartmentComplexes> ApartmentComplexes { get; set; }
    }
}
