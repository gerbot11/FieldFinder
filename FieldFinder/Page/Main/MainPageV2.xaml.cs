using FieldFinder.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FieldFinder.Page.Main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageV2 : ContentPage
    {
        //public MainViewModel Mvm => BindingContext as MainViewModel;
        public MainPageV2()
        {
            InitializeComponent();
            BindingContext = new MainViewModel(Navigation);
        }
    }
}