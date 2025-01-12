using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Blog.DataLayer.Entities
{
    public class User: BaseEntity<long> 
    {

        [Required]
        [StringLength(25)]
        public string UserName { get; set; }

        [Required]
        [StringLength(25)]
        public string FullName { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 8)]
        public string Password { get; set; }
        [Required]

        #region Relations
        public ICollection<Post> Posts { get; set; }
        public ICollection<PostComment> PostComments { get; set; }
        #endregion
    }
}
