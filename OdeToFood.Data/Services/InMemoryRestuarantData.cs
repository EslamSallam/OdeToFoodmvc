using OdeToFood.Data.Model;
using System;
using System.Collections.Generic;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestuarantData : IRestuarantData
    {
        List<Restuarant> restuarants;

        public InMemoryRestuarantData()
        {
            restuarants = new List<Restuarant>()
            {
                new Restuarant {ID = 1,Name = "Eslam's Pizza", Cuisine = CuisineType.Italian},
                new Restuarant {ID = 2,Name = "Tersiguels", Cuisine = CuisineType.French},
                new Restuarant {ID = 3,Name = "Mango Grove", Cuisine = CuisineType.Indian}
            };
        }
        public IEnumerable<Restuarant> GetAll()
        {
            return restuarants;
        }
    }
}
