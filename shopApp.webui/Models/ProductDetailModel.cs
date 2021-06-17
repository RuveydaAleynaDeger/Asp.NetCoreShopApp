using System.Collections.Generic;
using shopApp.entity;

namespace shopApp.webui.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }

        public List<Category> Categories { get; set; }
    }
}