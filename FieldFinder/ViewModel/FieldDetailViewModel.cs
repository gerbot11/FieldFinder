using FieldFinder.API;
using FieldFinder.Model;
using FieldFinder.Page.Submenu;
using MvvmHelpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FieldFinder.ViewModel
{
    public class FieldDetailViewModel : BaseViewModel
    {
        private readonly IFieldService ifs = DependencyService.Get<IFieldService>();
        private long Id { get; set; }
        private FieldDetailModel FieldDetailModel;
        private readonly INavigation Navigation;

        public FieldDetailModel FieldDetails { get => FieldDetailModel; set => OnPropertyChanged("FieldDetails"); }
        public Command GoToSchedule { get; set; }

        public FieldDetailViewModel(long Id, INavigation navigation)
        {
            this.Id = Id;
            Navigation = navigation;
            GoToSchedule = new Command(() =>
            {
                Xamarin.Forms.Page schedulePage = new VendorSchedule();
                Navigation.PushModalAsync(schedulePage);
            });
            Device.BeginInvokeOnMainThread(() =>
            {
                _ = SetDetailAsync();
                
            });
        }

        private async Task SetDetailAsync()
        {
            FieldDetailModel = await GetDetailAsync();
            FieldDetails = FieldDetailModel;
        }

        private async Task<FieldDetailModel> GetDetailAsync()
        {
            IsBusy = true;
            FieldDetailModel detailModel = await ifs.GetDetailModelAsync(Id);
            if (detailModel != null)
            {
                detailModel.Image = $"http://{detailModel.Image}";
            }
            IsBusy = false;
            return detailModel;
        }
    }
}
