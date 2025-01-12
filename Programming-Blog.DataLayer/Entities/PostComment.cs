using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Blog.DataLayer.Entities
{
    public class PostComment: BaseEntity<long>
    {
        // public int UserId { get; set; }
        [Required]
        public int RoleId { get; set; }
        public long PostId { get; set; }
        [Required]

        public string Text { get; set; }

        #region Relations
        [ForeignKey("PostId")]
        public Post Post { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }
        #endregion

    }
}
