using FieldFinder.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FieldFinder.Page.Submenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FieldDetail : ContentPage
    {   
        public FieldDetail(long fieldId)
        {
            InitializeComponent();
            BindingContext = new FieldDetailViewModel(fieldId, Navigation);
        }
    }
}