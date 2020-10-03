using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArwinTolentino.CookingRecipePortal.Windows.Models
{
    public class Tag
    {
      [Key] public string Title { get; set; }
        public string FeedBack { get; set; }
        public string Price { get; set; }
    }
}