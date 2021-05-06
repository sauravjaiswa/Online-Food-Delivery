using OnlineFoodDelivery.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OnlineFoodDelivery.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantByName(string name);
        Restaurant GetById(int id);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=1,Name="ABC",Location="Dreamland", Cuisine=CuisineType.Italian},
                new Restaurant{Id=2,Name="DEF",Location="Wonderland", Cuisine=CuisineType.Mexican},
                new Restaurant{Id=3,Name="GHI",Location="Streetland", Cuisine=CuisineType.Indian}
            };  
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string name=null)
        {
            return from r in restaurants
                    where string.IsNullOrEmpty(name)||r.Name.StartsWith(name)
                    orderby r.Name
                    select r;
        }
    }
}
