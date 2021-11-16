using FieldFinder.API;
using FieldFinder.Model.Venue;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FieldFinder.Service
{
    public class VenueService : IVenueService
    {
        public ObservableCollection<VenueModel> GetNearbyVenue()
        {
            List<string> fieldType = new List<string>()
            {
                "FTSL",
                "BBALL"
            };

            return new ObservableCollection<VenueModel>()
            {
                new VenueModel() {VenueId = 1, Detail = "Lorem Ipsum", Latitude = "-3.6690083032573493", Longitude = "128.19731975668736", Rating = "4.4", VenueName = "Futsal Halong", Image = "smpl_futsal_halong.jpg", FieldType = fieldType}
            };
        }

        public VenueModel GetVenueModel(long venueId)
        {
            return null;
        }
    }
}
