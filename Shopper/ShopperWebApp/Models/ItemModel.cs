using System.Collections.Generic;

namespace ShopperWebApp.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public CategoryModel Category { get; set; }
        public List<PictureModel> Pictures { get; set; } = new List<PictureModel>();
    }
}
