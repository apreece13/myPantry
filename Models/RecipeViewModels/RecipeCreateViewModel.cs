using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myPantry.Models.RecipeViewModels
{
    public class RecipeCreateViewModel
    {
        public Recipe recipe { get; set; }
        public Products product { get; set; }

        public List<SelectListItem> products { get; set; } = new List<SelectListItem>();

        public List<int> SelectedProducts { get; set; } = new List<int>();
    }
}
