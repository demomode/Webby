using Webby.Data.Interfaces;
using Webby.Data.Models;
using System.Collections.Generic;

namespace Webby.Data.Mocks
{
    public class MockCategory : ICarsCategory {

		public IEnumerable<Category> AllCategories {
			get {
				return new List<Category> {
					new Category { category_name = "electro", desc = "new age cars" }, 
					new Category { category_name = "classic", desc = "previous age cars" }
				};
			}
		}

    }
}