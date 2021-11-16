using System;
using System.Collections.Generic;

#nullable disable

namespace FieldFinder.DataModel.Model
{
    public partial class FieldSchedule
    {
        public long FieldScheduleId { get; set; }
        public long? VenueFieldId { get; set; }
        public string DayNight { get; set; }
        public DateTime ScheduleDt { get; set; }
        public TimeSpan ScheduleTime { get; set; }
        public string IsBooked { get; set; }
        public decimal? OverridePrice { get; set; }
        public string Discount { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string IsSystemCopy { get; set; }
        public int? SysCopyDayAhead { get; set; }

        public virtual VenueField VenueField { get; set; }
    }
}
