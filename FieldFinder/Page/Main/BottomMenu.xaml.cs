using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FieldFinder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomMenu : TabbedPage
    {
        public BottomMenu()
        {
            InitializeComponent();
        }

        //protected override bool OnBackButtonPressed()
        //{
        //    return base.OnBackButtonPressed();
        //}
    }
}