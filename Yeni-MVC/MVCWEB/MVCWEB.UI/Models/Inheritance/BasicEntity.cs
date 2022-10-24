using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWEB.UI.Models.Inheritance
{
    public class BasicEntity
    {
        public BasicEntity()
        {
            this.ID = Guid.NewGuid();
        }

        [Key]
        public Guid ID { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime LastDate { get; set; }
    }
}