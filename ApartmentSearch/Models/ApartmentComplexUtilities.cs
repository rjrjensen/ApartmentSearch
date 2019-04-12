using System;
using System.Collections.Generic;

namespace ApartmentSearch.Models
{
    public partial class ApartmentComplexUtilities
    {
        public ApartmentComplexUtilities()
        {
            ApartmentComplexFees = new HashSet<ApartmentComplexFees>();
        }

        public int Id { get; set; }
        public decimal? Electricity { get; set; }
        public decimal? Gas { get; set; }
        public decimal? Water { get; set; }
        public decimal? Cable { get; set; }
        public decimal? Internet { get; set; }
        public decimal? Garbage { get; set; }

        public virtual ICollection<ApartmentComplexFees> ApartmentComplexFees { get; set; }
    }
}
