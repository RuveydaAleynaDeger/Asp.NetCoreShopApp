using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopApp.entity;

namespace shopApp.webui.Models
{
    public class ProductModel
    {

        public int ProductId { get; set; }
        
        // [Required(ErrorMessage="Zorunlu alan")]
        // [StringLength(60,MinimumLength=5,ErrorMessage="Ürün ismi 5-10 karakter alaralığında olmalıdır.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage="Zorunlu alan")]
        public string Url { get; set; }
        
        // [Required(ErrorMessage="Zorunlu alan")]
        // [Range(1,100000,ErrorMessage="Fiyat alanı için 1-100000 arasında değer girmelisiniz.")]
        public double Price { get; set; }
        
        [Required(ErrorMessage="Zorunlu alan")]
        public string Description { get; set; }
        
        // [Required(ErrorMessage="Zorunlu alan")]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
        
    }
}