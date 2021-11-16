using FieldFinder.Model.Venue;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace FieldFinder.ViewModel
{
    public class VenueDetailViewModel : BaseViewModel
    {
        private long VenueId;

        public VenueModel VenueModel { get; set; }
        public VenueDetailViewModel(long _venueId)
        {
            VenueId = _venueId;
        }
    }
}
