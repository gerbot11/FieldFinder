using FieldFinder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FieldFinder.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageV2Page : ContentPage
    {
        
        public MainPageV2Page()
        {
            InitializeComponent();
        }

        private List<NearYouModel> SetListNearYou()
        {
            return new List<NearYouModel>
            {
                new NearYouModel { Id=1, Image = "apt1.png", Address = "2162 Patricia Ave, LA", Location = "Ambon", Price = "Rp200,000/Jam", Review = "4.5", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies integer quis. Iaculis urna id volutpat lacus laoreet. Mauris vitae ultricies leo integer malesuada. Ac odio tempor orci dapibus ultrices in. Egestas diam in arcu cursus euismod. Dictum fusce ut" },
                new NearYouModel { Id=2, Image = "apt2.png", Address = "2168 Cushions Dr, LA", Location = "Ambon", Price = "Rp100,000/Jam", Review = "3", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies integer quis. Iaculis urna id volutpat lacus laoreet. Mauris vitae ultricies leo integer malesuada. Ac odio tempor orci dapibus ultrices in. Egestas diam in arcu cursus euismod. Dictum fusce ut" },
                new NearYouModel { Id=3, Image = "apt3.png", Address = "2112 Anthony Way, LA", Location = "Masohi", Price = "Rp170,000/Jam", Review = "4", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies integer quis. Iaculis urna id volutpat lacus laoreet. Mauris vitae ultricies leo integer malesuada. Ac odio tempor orci dapibus ultrices in. Egestas diam in arcu cursus euismod. Dictum fusce ut" },
            };
        }
    }
}