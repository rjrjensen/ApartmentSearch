using System;
using System.Collections.Generic;

namespace ApartmentSearch.Models
{
    public partial class ApartmentFloorPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rent { get; set; }
        public int SquareFootage { get; set; }
        public int Beds { get; set; }
        public int Baths { get; set; }
        public int StyleId { get; set; }
        public int? RatingId { get; set; }
        public bool LooksUpdated { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasWalkInCloset { get; set; }
        public bool HasIceMaker { get; set; }
        public bool HasAttachedGarage { get; set; }

        public virtual ApartmentRating Rating { get; set; }
        public virtual ApartmentStyle Style { get; set; }
    }
}
