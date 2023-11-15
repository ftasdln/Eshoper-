using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int? ProductId { get; set; }
        public string? ProductName  { get; set; }
        public string? ProductDescription { get; set; }
        public int? ProductPrice { get; set; }
        public int? DiscountPrice { get; set; }

        virtual public Pictures? Pictures { get; set; }
        public int? PictureId { get; set; }

        virtual public Category? Category { get; set; }
        public int? CategoryId { get; set; }

        public int? ProductFeature { get; set; }

        public int? SizeId { get; set; }
        virtual public Sizes? Sizes { get; set; }

        virtual public Colors? Colors { get; set; } 
        public int? ColorId { get; set; }

        virtual public List<Comments>? Comments { get; set; }
    }
}
