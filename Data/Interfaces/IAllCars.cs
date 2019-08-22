using Webby.Data.Models;
using System.Collections.Generic;

namespace Webby.Data.Interfaces
{
    public interface IAllCars {
		IEnumerable<Car> Cars {get;}
		IEnumerable<Car> getFavCars {get; set;}
		Car getObjectCar(int car_id);
    }
}