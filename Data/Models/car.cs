using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webby.Data.Models {
	public class Car {
		
		public int id {set; get;}
		
		public string name {set; get;}
		
		public string short_desc {set; get;}
		
		public string long_dsc {set; get;}
		
		public string img {set; get;}
		
		public ushort price {set; get;}
		
		public bool is_favorite {set; get;}
		
		public int available {set; get;}
		
		public int category_id {set; get;}
		
		public virtual Category Category {set; get;}

	}
}