using System;
using System.ComponentModel.DataAnnotations;

namespace Didala.Models.Models
{
    public class SearchModel
    {
        [Required(ErrorMessage = "Min price is required")]
        public string MinPrice { get; set; }

        [Required(ErrorMessage = "Max price is required")]
        public string MaxPrice { get; set; }

        [Required(ErrorMessage = "Name price is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Tag is required")]
        public string Tag { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }
    }
}
