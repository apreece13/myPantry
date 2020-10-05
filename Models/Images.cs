using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myPantry.Models
{
    public class Images
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public Recipe RecipeImage { get; set; }
        public byte RecipeImages { get; set; }
    }
}
