using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myPantry.Models
{
    public class RecipeProducts
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int ProductId { get; set; }
        public Products Product { get; set; }
    }
}
