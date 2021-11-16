using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FieldFinder.Page.Main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnBoard : ContentPage
    {
        public OnBoard()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            MyRadialGradient.RadiusX = width * 6;
        }



        private async void Button_Clicked(object sender, EventArgs e)
        {
            await FadeBox.FadeTo(1, 500);
            await Navigation.PopModalAsync(false);
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //MyRadialGradient.RadiusX = this.Width * e.NewValue;
        }
    }
}