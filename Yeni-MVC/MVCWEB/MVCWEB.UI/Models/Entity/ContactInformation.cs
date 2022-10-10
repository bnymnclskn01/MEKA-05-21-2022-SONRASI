using MVCWEB.UI.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWEB.UI.Models.Entity
{
    public class ContactInformation : BasicEntity
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}