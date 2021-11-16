using System;
using System.Collections.Generic;

#nullable disable

namespace FieldFinder.DataModel.Model
{
    public partial class RefFieldType
    {
        public RefFieldType()
        {
            VenueFields = new HashSet<VenueField>();
        }

        public long RefFieldTypeId { get; set; }
        public string FieldTypeCode { get; set; }
        public string FieldTypeName { get; set; }
        public string IsActive { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }

        public virtual ICollection<VenueField> VenueFields { get; set; }
    }
}
