using System;
using System.Collections.Generic;

#nullable disable

namespace FieldFinder.DataModel.Model
{
    public partial class VenueField
    {
        public VenueField()
        {
            FieldSchedules = new HashSet<FieldSchedule>();
        }

        public long VenueFieldId { get; set; }
        public long? VenueId { get; set; }
        public long? RefFieldTypeId { get; set; }
        public string FieldName { get; set; }
        public decimal? Price { get; set; }
        public int? FieldLength { get; set; }
        public int? FieldWidth { get; set; }
        public int? FieldLarge { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }

        public virtual RefFieldType RefFieldType { get; set; }
        public virtual Venue Venue { get; set; }
        public virtual ICollection<FieldSchedule> FieldSchedules { get; set; }
    }
}
