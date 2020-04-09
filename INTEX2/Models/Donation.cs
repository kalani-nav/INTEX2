using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INTEX2.Models
{
    public class Donation
    {
        [Key]
        [DisplayName("Donation Id")]
        public int donation_id { get; set; }

        [DisplayName("Campaign Id")]
        public int campaign_id { get; set; }

        [DisplayName("Category")]
        public string collected_date { get; set; }

        [DisplayName("Amount")]
        public int amount { get; set; }

        [DisplayName("Is Offline")]
        public Boolean is_offline { get; set; }

        [DisplayName("Is Anonymous")]
        public Boolean is_anonymous { get; set; }

        [DisplayName("Name")]
        public string name { get; set; }

        [DisplayName("Created At")]
        public string created_at { get; set; }

        [DisplayName("Profile URL")]
        public string profile_url { get; set; }

        [DisplayName("Verified")]
        public Boolean verified { get; set; }
    }
}