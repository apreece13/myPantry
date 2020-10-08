using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myPantry.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public Users User { get; set; }
        public string Description { get; set; }
        public string RecipeUrl { get; set; }
        //List<RecipeProducts> RecipeProducts { get; set; } = new List<RecipeProducts>();
        public virtual ICollection<RecipeProducts> RecipeProducts { get; set; }
    }
}
