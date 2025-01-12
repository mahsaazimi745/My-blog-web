using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Blog.DataLayer.Entities
{
   public class Category:BaseEntity<int>
    {
        [Required]
        public int ParentId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Slug { get; set; }

        public string MetaTag { get; set; }

        public int MetaDescription { get; set; }

        #region Relations 
        public ICollection<Post> Posts { get; set; }
        #endregion
    }
}
