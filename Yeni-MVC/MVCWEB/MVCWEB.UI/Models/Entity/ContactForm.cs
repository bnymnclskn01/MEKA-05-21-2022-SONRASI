using MVCWEB.UI.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWEB.UI.Models.Entity
{
    public class ContactForm : BasicEntity
    {
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}