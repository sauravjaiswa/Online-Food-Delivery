using OnlineFoodDelivery.Core;
using System.Collections.Generic;
using System.Text;

namespace OnlineFoodDelivery.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantByName(string name);
        Restaurant GetById(int id);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Delete(int id);
        int GetCountOfRestaurant();
        int Commit();
    }
}
