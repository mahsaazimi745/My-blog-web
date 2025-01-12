using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Blog.DataLayer.Entities
{
    public class BaseEntity<Tkey>
    {
        [Key]
        public Tkey Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public bool IsDelete { get; set; }
    }
}
