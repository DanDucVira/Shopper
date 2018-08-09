using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShopperWebApp.Models
{
    public class ItemModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [DisplayName("Sell price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public CategoryModel Category { get; set; }

        [DisplayName("Item pictures")]
        public List<PictureModel> Pictures { get; set; } = new List<PictureModel>();
    }
}
