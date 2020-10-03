using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArwinTolentino.CookingRecipePortal.Windows.Models
{
    public class Ingredient
    {
        [Key] public string Name { get; set; }
      public string UnitMeasure { get; set; }
    }
}
