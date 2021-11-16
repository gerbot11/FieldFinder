using System;
using System.Collections.Generic;
using System.Text;

namespace FieldFinder.Model
{
    public class CategoryModel
    {
        public string Name { get; set; }
        public string Img { get; set; }
        public List<CategoryModel> SetCategory()
        {
            return new List<CategoryModel>
            {
                new CategoryModel { Name = "Futsal", Img = "football.png" },
                new CategoryModel { Name = "Basketball", Img = "basketball.png" },
                new CategoryModel { Name = "Badminton", Img = "badminton.png" },
                new CategoryModel { Name = "Gym", Img = "dumbbell.png" }
            };
        }
    }
}