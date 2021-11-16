using FieldFinder.Model.Venue;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FieldFinder.API
{
    public interface IVenueService
    {
        ObservableCollection<VenueModel> GetNearbyVenue();
    }
}
