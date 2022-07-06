using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "bos qoyma"), MaxLength(20)]
        public string Name { get; set; }
        [Required, MinLength(100)]
        public string Desc { get; set; }
        public List<Product> Products { get; set; }
    }
}
