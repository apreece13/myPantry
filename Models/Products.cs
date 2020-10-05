using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myPantry.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int LocationId { get; set; }
        public Location ProductLocation { get; set; }
        public byte ProductImage { get; set; }
        public string UserId { get; set; }
        public Users ProductUser { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductProductType { get; set; }
        List<RecipeProducts> RecipeProducts { get; set; } = new List<RecipeProducts>();

    }
}
