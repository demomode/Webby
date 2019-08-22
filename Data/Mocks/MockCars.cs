using Webby.Data.Interfaces;
using Webby.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System;


namespace Webby.Data.Mocks
{
    public class MockCars : IAllCars {

	private readonly ICarsCategory _categoryCars = new MockCategory();

	public IEnumerable<Car> Cars {
			get {
				return new List<Car> {
					new Car {
						name = "Car One", 
						short_desc = "Short description One", 
						long_dsc = "This is long description numer one", 
						img = "https://i.pinimg.com/236x/2b/9b/43/2b9b43f9842312acceaf59333147203a--kids-numbers-math-numbers.jpg", 
						price = 1001, 
						is_favorite = true, 
						available = true, 
						Category = _categoryCars.AllCategories.First()
					}, 
					
					new Car {
						name = "Car Two", 
						short_desc = "Short description Two", 
						long_dsc = "This is long description numer two", 
						img = "https://i.pinimg.com/236x/a0/d3/7b/a0d37b41b6d3d8ab3ba6bde2f675d7eb--math-education-free-coloring-pages.jpg", 
						price = 2002, 
						is_favorite = true, 
						available = true, 
						Category = _categoryCars.AllCategories.Last()
					}, 
					
					new Car {
						name = "Car Three", 
						short_desc = "Short description three", 
						long_dsc = "This is long description numer three", 
						img = "https://ds05.infourok.ru/uploads/ex/01fa/0002ad91-9671c235/hello_html_8d01e9f.jpg", 
						price = 3003, 
						is_favorite = true, 
						available = true, 
						Category = _categoryCars.AllCategories.First()
					}, 

					new Car {
						name = "Car Four", 
						short_desc = "Short description four", 
						long_dsc = "This is long description numer four", 
						img = "https://zabavnik.club/wp-content/uploads/4_6_07015311.jpg", 
						price = 4004, 
						is_favorite = true, 
						available = true, 
						Category = _categoryCars.AllCategories.Last()
					}, 
				};
			}
	}

		public IEnumerable<Car> getFavCars {get; set;}

		public Car getObjectCar(int car_id) => throw new NotImplementedException();


	}
}