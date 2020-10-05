using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myPantry.Models
{
    public class Users : IdentityUser 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
