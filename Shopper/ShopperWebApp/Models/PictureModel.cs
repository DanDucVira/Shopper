using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopperWebApp.Models
{
    public class PictureModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int Order { get; set; }
        public bool IsHeader { get; set; }
    }
}
