using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FieldFinder.Model
{
    public class NearYouModel
    {
        public long Id { get; set; }
        public string PropertyName { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Price { get; set; }
        public string Review { get; set; }
        public string Details { get; set; }
        public Command GoToDetailPage { get; set; }
    }
}
