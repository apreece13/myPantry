using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myPantry.Models.ProductViewModels
{
    public class RecipeCreateViewModel
    {
        public Products product { get; set; }

        public List<SelectListItem> products { get; set; } = new List<SelectListItem>();
    }
}
