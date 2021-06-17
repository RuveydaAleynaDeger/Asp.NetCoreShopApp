using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopApp.entity;

namespace shopApp.webui.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage="Kategori adı zorunludur.")]
        public string Name { get; set; }
        public string Url { get; set; }
        
        public List<Product> Products { get; set; }
    }
}