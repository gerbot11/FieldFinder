using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FieldFinder.Model
{
    public class FieldDetailModel
    {
        public long Id { get; set; }
        public string FieldName { get; set; }
        public string Location { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string Details { get; set; }
        public string Address { get; set; }
    }
}
