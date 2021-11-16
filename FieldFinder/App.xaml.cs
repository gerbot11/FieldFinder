using FieldFinder.API;
using FieldFinder.Page.Main;
using FieldFinder.Service;
using Xamarin.Forms;

[assembly: ExportFont("NunitoSans-Bold.ttf", Alias = "BoldFont")]
[assembly: ExportFont("NunitoSans-Regular.ttf", Alias = "RegularFont")]
[assembly: ExportFont("NunitoSans-SemiBold.ttf", Alias = "SemiBoldFont")]
namespace FieldFinder
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Inject Dependency di sini bang
            DependencyService.Register<IFieldService, FieldService>();
            DependencyService.Register<IVenueService, VenueService>();

            MainPage = new HomePage();
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
