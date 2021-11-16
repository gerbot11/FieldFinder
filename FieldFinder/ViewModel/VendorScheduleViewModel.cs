using FieldFinder.Model;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FieldFinder.ViewModel
{
    public class VendorScheduleViewModel : BaseViewModel
    {
        public ObservableCollection<DateSelectionList> DateSelectionLists => SetDateSelection();
        public ObservableCollection<VendorScheduleModel> ListSchedule => GetListFieldSchedule();
        public VendorScheduleViewModel()
        {

        }

        private ObservableCollection<DateSelectionList> SetDateSelection()
        {
            ObservableCollection<DateSelectionList> dateSelectionLists = new ObservableCollection<DateSelectionList>();
            DateTime today = DateTime.Today;
            int totalDay = 14;
            for (int i = 0; i <= totalDay; i++)
            {
                DateSelectionList dates = new DateSelectionList()
                {
                    Date = today.AddDays(i).ToString("dd MMM"),
                    Day = today.AddDays(i).ToString("ddd").ToUpper()
                };
                dateSelectionLists.Add(dates);
            }
            return dateSelectionLists;
        }

        private ObservableCollection<VendorScheduleModel> GetListFieldSchedule()
        {
            ObservableCollection<VendorScheduleModel> schedules = new ObservableCollection<VendorScheduleModel>();
            int dummy = 5;

            for (int i = 0; i <= dummy; i++)
            {
                VendorScheduleModel model = new VendorScheduleModel()
                {
                    FieldName = $"Lapangan {i}",
                    FieldType = "Futsal",
                    Price = "120,000",
                    Image = "onboard_futsal.jpg",
                    TimeAvailables = new List<TimeAvailable>()
                };

                for (int l = 0; l < 10; l++)
                {
                    TimeAvailable available = new TimeAvailable()
                    {
                        Time = l.ToString()
                    };
                    model.TimeAvailables.Add(available);
                }

                schedules.Add(model);
            }

            return schedules;
        }
    }
}
