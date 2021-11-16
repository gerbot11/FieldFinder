using System;
using System.Collections.Generic;

#nullable disable

namespace FieldFinder.DataModel.Model
{
    public partial class Venue
    {
        public Venue()
        {
            VenueAddresses = new HashSet<VenueAddress>();
            VenueFields = new HashSet<VenueField>();
        }

        public long VenueId { get; set; }
        public string VenueName { get; set; }
        public string Detail { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public DateTime EstablishedDt { get; set; }
        public string VenueOwner { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual ICollection<VenueAddress> VenueAddresses { get; set; }
        public virtual ICollection<VenueField> VenueFields { get; set; }
    }
}
