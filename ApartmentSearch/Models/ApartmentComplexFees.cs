using System;
using System.Collections.Generic;

namespace ApartmentSearch.Models
{
    public partial class ApartmentComplexFees
    {
        public ApartmentComplexFees()
        {
            ApartmentComplexes = new HashSet<ApartmentComplexes>();
        }

        public int Id { get; set; }
        public decimal? ApplicationFee { get; set; }
        public decimal? AdministrativeFee { get; set; }
        public decimal? SecurityDeposit { get; set; }
        public decimal? PetFee { get; set; }
        public decimal? PetRent { get; set; }
        public decimal? GarageFee { get; set; }
        public int? UtilityId { get; set; }

        public virtual ApartmentComplexUtilities Utility { get; set; }
        public virtual ICollection<ApartmentComplexes> ApartmentComplexes { get; set; }
    }
}
