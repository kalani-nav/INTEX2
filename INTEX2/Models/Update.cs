using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX2.Models
{
    public class Update
    {
        [Key]
        [DisplayName("Update Id")]
        public int update_id { get; set; }

        [DisplayName("Campaign Id")]
        public int campaign_id { get; set; }

        [DisplayName("Photo URL")]
        public string photo_url { get; set; }

        [DisplayName("Created At")]
        public string created_at { get; set; }

        [DisplayName("Updates Author")]
        public string updates_author { get; set; }

        [DisplayName("Updates Text")]
        public string updates_text { get; set; }
    }
}