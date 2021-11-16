using System;
using System.Collections.Generic;

#nullable disable

namespace FieldFinder.DataModel.Model
{
    public partial class VenueAddress
    {
        public long VenueAddressId { get; set; }
        public long? VenueId { get; set; }
        public string AddressDetail { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }

        public virtual Venue Venue { get; set; }
    }
}
