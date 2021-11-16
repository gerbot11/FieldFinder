using FieldFinder.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FieldFinder.Page.Submenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VenueDetail : ContentPage
    {
        public VenueDetail(long venueId)
        {
            InitializeComponent();
            BindingContext = new VenueDetailViewModel(venueId);
        }
    }
}