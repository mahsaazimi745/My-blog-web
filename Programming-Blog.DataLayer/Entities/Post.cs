using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Blog.DataLayer.Entities
{
    public class Post: BaseEntity<long>
    {
        // public int RoleToUserId { get; set; }
        [Required]
        public long UserId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(300)]
        public string Title { get; set; }
        [Required]
        [MaxLength(400)]
        public string Slug { get; set; }
        [Required]
        public string Description { get; set; }
        public int Visit { get; set; }

        #region Relations
        [ForeignKey("UserId")]
        public User User { get; set; }
        //public RoleToUser RoleToUser{ get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public ICollection<PostComment> PostComments { get; set; }
        #endregion

    }
}
