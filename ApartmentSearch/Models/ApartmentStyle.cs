using System;
using System.Collections.Generic;

namespace ApartmentSearch.Models
{
    public partial class ApartmentStyle
    {
        public ApartmentStyle()
        {
            ApartmentFloorPlan = new HashSet<ApartmentFloorPlan>();
        }

        public int Id { get; set; }
        public string Style { get; set; }

        public virtual ICollection<ApartmentFloorPlan> ApartmentFloorPlan { get; set; }
    }
}
