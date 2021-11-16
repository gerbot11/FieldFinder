using System;
using System.Collections.Generic;
using System.Text;

namespace FieldFinder.Model.Field
{
    public class VenueField
    {
        public long FieldId { get; set; }
        public long VenueId { get; set; }
        public string FieldName { get; set; }
        public string Price { get; set; }
        public string FieldType { get; set; }
    }
}
