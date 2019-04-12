using System;
using System.Collections.Generic;

namespace ApartmentSearch.Models
{
    public partial class ApartmentComplexes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public int ContactId { get; set; }
        public int FeesId { get; set; }
        public string Website { get; set; }

        public virtual ApartmentComplexAddresses Address { get; set; }
        public virtual ApartmentComplexContacts Contact { get; set; }
        public virtual ApartmentComplexFees Fees { get; set; }
    }
}
