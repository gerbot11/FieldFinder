using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FieldFinder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        
        public List<PropertyType> PropertyTypeList => GetPropertyTypes();
        public List<Property> PropertyList => GetProperties();
        public class PropertyType
        {
            public string TypeName { get; set; }
            public string Url { get; set; }
        }

        public class Property
        {
            public string Id => Guid.NewGuid().ToString("N");
            public string PropertyName { get; set; }
            public string Image { get; set; }
            public string Address { get; set; }
            public string Location { get; set; }
            public string Price { get; set; }
            public string Review { get; set; }
            public string Details { get; set; }
        }

        private List<PropertyType> GetPropertyTypes()
        {
            return new List<PropertyType>
            {
                new PropertyType { TypeName = "Futsal", Url = "football.png" },
                new PropertyType { TypeName = "Basketball", Url = "basketball.png" },
                new PropertyType { TypeName = "Badminton", Url = "badminton.png" },
                new PropertyType { TypeName = "Gym", Url = "dumbbell.png" }
            };
        }

        private List<Property> GetProperties()
        {
            return new List<Property>
            {
                new Property { Image = "apt1.png", Address = "2162 Patricia Ave, LA", Location = "Ambon", Price = "Rp200,000/Jam", Review = "4.5", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies integer quis. Iaculis urna id volutpat lacus laoreet. Mauris vitae ultricies leo integer malesuada. Ac odio tempor orci dapibus ultrices in. Egestas diam in arcu cursus euismod. Dictum fusce ut" },
                new Property { Image = "apt2.png", Address = "2168 Cushions Dr, LA", Location = "Ambon", Price = "Rp100,000/Jam", Review = "3", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies integer quis. Iaculis urna id volutpat lacus laoreet. Mauris vitae ultricies leo integer malesuada. Ac odio tempor orci dapibus ultrices in. Egestas diam in arcu cursus euismod. Dictum fusce ut" },
                new Property { Image = "apt3.png", Address = "2112 Anthony Way, LA", Location = "Masohi", Price = "Rp170,000/Jam", Review = "4", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies integer quis. Iaculis urna id volutpat lacus laoreet. Mauris vitae ultricies leo integer malesuada. Ac odio tempor orci dapibus ultrices in. Egestas diam in arcu cursus euismod. Dictum fusce ut" },
            };
        }

        private void ChangeTextColor(View child, string hexColor)
        {
            Label txtCtrl = child.FindByName<Label>("PropertyTypeName");

            if (txtCtrl != null)
                txtCtrl.TextColor = Color.FromHex(hexColor);
        }

        private void SelectType(object sender, EventArgs e)
        {
            View view = sender as View;
            StackLayout parent = view.Parent as StackLayout;

            foreach (var child in parent.Children)
            {
                VisualStateManager.GoToState(child, "Normal");
                ChangeTextColor(child, "#707070");
            }

            VisualStateManager.GoToState(view, "Selected");
            ChangeTextColor(view, "#FFFFFF");
        }

    }
}
