using Webby.Data.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Webby.Data.Interfaces {
    public interface ICarsCategory {
         IEnumerable<Category> AllCategories {get;}

    }
}