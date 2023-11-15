using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comments
    {
        [Key]
        public int? CommentId { get; set; }
        public string? Commenter { get; set; }
        public string? CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public int? ProductId { get; set; }
        virtual public Product? Products  { get; set;}
    }
}
