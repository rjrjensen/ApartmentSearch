using System;
using System.Collections.Generic;

namespace ApartmentSearch.Models
{
    public partial class ApartmentRating
    {
        public ApartmentRating()
        {
            ApartmentFloorPlan = new HashSet<ApartmentFloorPlan>();
        }

        public int Id { get; set; }
        public int Stars { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ApartmentFloorPlan> ApartmentFloorPlan { get; set; }
    }
}
