using FieldFinder.API;
using FieldFinder.Model;
using FieldFinder.Model.Venue;
using FieldFinder.Page.Submenu;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FieldFinder.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IFieldService ifs = DependencyService.Get<IFieldService>();
        private readonly IVenueService ivs = DependencyService.Get<IVenueService>();
        #region PRIVATE PROPS
        private INavigation Nav { get; set; }
        private MainModel mainModel;
        private string currCity;
        private bool visibleMsg;
        private bool visibleContent;
        #endregion

        public MainModel MainModel
        {
            get => mainModel; set => OnPropertyChanged("MainModel");
        }
        public string CurrentCity
        {
            get => currCity; set => OnPropertyChanged("CurrentCity");
        }
        public bool IsVisibleContent { get => visibleContent; set => OnPropertyChanged("IsVisibleContent"); }
        public bool IsVisibleMsg { get => visibleMsg; set => OnPropertyChanged("IsVisibleMsg"); }

        public MainViewModel(INavigation nav)
        {
            Nav = nav;

            Device.BeginInvokeOnMainThread(() =>
            {
                _ = SetNearyouDataAsync();
                _ = SetDataLocationAsync();
                
            });
        }

        
        private async Task SetNearyouDataAsync()
        {
            mainModel = new MainModel
            {
                //NearYouModel = await SetListNearYou(),
                venueModels = await SetNearbyVenue()
            };
            MainModel = mainModel;
            IsVisibleMsg = visibleMsg;
            IsVisibleContent = visibleContent;
        }

        private async Task SetDataLocationAsync()
        {
            currCity = await OnGetAddressAsync();
            CurrentCity = currCity;
        }

        private async Task<ObservableCollection<NearYouModel>> SetListNearYou()
        {
            ObservableCollection<NearYouModel> nearYouModels = await ifs.SetDataNearYou();
            foreach (NearYouModel item in nearYouModels)
            {
                item.GoToDetailPage = new Command(async () =>
                {
                    Xamarin.Forms.Page detailFieldPage = new VenueDetail(item.Id);
                    await Nav.PushAsync(detailFieldPage);
                });
            }

            return nearYouModels;
        }

        private async Task<string> OnGetAddressAsync()
        {
            //IsBusy = true;
            string currCity;

            Location location = await Geolocation.GetLastKnownLocationAsync();
            double lat, lng;
            lat = location.Latitude;
            lng = location.Longitude;

            IEnumerable<Placemark> placemarks = await Geocoding.GetPlacemarksAsync(lat, lng);
            Placemark placemark = placemarks.FirstOrDefault();
            if (placemark == null)
            {
                currCity = "Unable to detect placemarks.";
            }
            else
            {
                currCity = $"{placemark.SubAdminArea}, {placemark.AdminArea}";
            }

            return currCity;
        }

        private async Task<ObservableCollection<VenueModel>> SetNearbyVenue()
        {
            ObservableCollection<VenueModel> listNearbyVenue = ivs.GetNearbyVenue();
            if (listNearbyVenue != null)
            {
                visibleContent = true;
                visibleMsg = false;
                foreach (VenueModel data in listNearbyVenue)
                {
                    data.DistToLoc = await CalculateDistanceToLoc(Convert.ToDouble(data.Longitude), Convert.ToDouble(data.Latitude)) + " Km";
                    data.GoToDetailPage = new Command(async () =>
                    {
                        Xamarin.Forms.Page detailFieldPage = new VenueDetail(data.VenueId);
                        await Nav.PushAsync(detailFieldPage);
                    });
                }
            }
            else
            {
                visibleContent = false;
                visibleMsg = true;
            }

            return listNearbyVenue;
        }

        private async Task<string> CalculateDistanceToLoc(double endLat, double endLng)
        {
            Location location = await Geolocation.GetLastKnownLocationAsync();
            double distance = Location.CalculateDistance(location, endLat, endLng, DistanceUnits.Kilometers) / 1000;
            return Math.Round(distance, 2).ToString();
        }
    }
}
