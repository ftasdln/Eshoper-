using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Pictures
    {
        [Key]
        public int? PictureId { get; set; }
        public string? PictureName { get; set; }
        public string? PicturePath { get; set; }

        virtual public List<Product>? Products { get; set; } 

        [NotMapped]
       public IFormFile? PictureUrl { get; set; }

      

    }
}
