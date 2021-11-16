using System.Collections.Generic;
using Xamarin.Forms;

namespace FieldFinder.Model.Venue
{
    public class VenueModel
    {
        public long VenueId { get; set; }
        public string VenueName { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
        public string Rating { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string DistToLoc { get; set; }
        public IEnumerable<string> FieldType { get; set; }
        public Command GoToDetailPage { get; set; }
    }
}
