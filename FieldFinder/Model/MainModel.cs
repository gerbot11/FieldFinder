using FieldFinder.Model.Venue;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FieldFinder.Model
{
    public class MainModel
    {
        public string CurrentCity { get; set; }
        public ObservableCollection<NearYouModel> NearYouModel { get; set; }
        public ObservableCollection<VenueModel> venueModels { get; set; }
    }
}
