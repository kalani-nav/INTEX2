
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX2.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [DisplayName("ID")]
        public String Id { get; set; }

        [DisplayName("Username")]
        public String username { get; set; }

        [DisplayName("Password")]
        public String password{ get; set; }

        [DisplayName("Type")]
        public String type { get; set; }

    }
}