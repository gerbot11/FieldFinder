using System;
using System.Collections.Generic;
using System.Text;

namespace FieldFinder.Model
{
    public partial class VendorScheduleModel
    {
        public string FieldType { get; set; }
        public string FieldName { get; set; }
        public List<TimeAvailable> TimeAvailables { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}
