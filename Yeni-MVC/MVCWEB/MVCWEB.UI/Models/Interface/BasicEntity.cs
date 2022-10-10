using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWEB.UI.Models.Interface
{
    public class BasicEntity
    {
        public BasicEntity()
        {
            this.ID = Guid.NewGuid();
        }

        [Key]
        public Guid ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastedDAte { get; set; }
    }
}