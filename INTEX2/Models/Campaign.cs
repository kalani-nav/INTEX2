using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX2.Models
{
    [Table("covid19_campaigns8")]
    public class Campaign
    {
        [DisplayName("id")]
        public String id { get; set; }

        [DisplayName("url")]
        public String url { get; set; }

        [Key]
        [DisplayName("Campaign Id")]
        public String campaign_id { get; set; }

        [DisplayName("Auto FB Post Made")]
        public String auto_fb_post_mode { get; set; }

        [DisplayName("Collected Date")]
        public String collected_date { get; set; }

        [DisplayName("Category Id")]
        public String category_id { get; set; }

        [DisplayName("Category")]
        public String category { get; set; }

        [DisplayName("Currency Code")]
        public String currencycode { get; set; }

        [DisplayName("Current Amount")]
        public String current_amount { get; set; }

        [DisplayName("Goal")]
        public String goal { get; set; }

        [DisplayName("Donators")]
        public String donators { get; set; }

        [DisplayName("Days Active")]
        public String days_active { get; set; }

        [DisplayName("Days Created")]
        public String days_created { get; set; }

        [DisplayName("Title")]
        public String title { get; set; }

        [DisplayName("Description")]
        public String description { get; set; }

        [DisplayName("Default URL")]
        public String default_url { get; set; }

        [DisplayName("Has Beneficiary")]
        public String has_beneficiary { get; set; }

        [DisplayName("Media Type")]
        public String media_type { get; set; }

        [DisplayName("Project Type")]
        public String project_type { get; set; }

        [DisplayName("Turn Off Donations")]
        public String turn_off_donations { get; set; }

        [DisplayName("User Id")]
        public String user_id { get; set; }

        [DisplayName("User First Name")]
        public String user_first_name { get; set; }

        [DisplayName("User Last Name")]
        public String user_last_name { get; set; }

        [DisplayName("User Facebook Id")]
        public String user_facebook_id { get; set; }

        [DisplayName("User Profile URL")]
        public String user_profile_url { get; set; }

        [DisplayName("Visible In Search")]
        public String visible_in_search { get; set; }

        [DisplayName("Status")]
        public String status { get; set; }

        [DisplayName("Deactivated")]
        public String deactivated { get; set; }

        [DisplayName("State")]
        public String state { get; set; }

        [DisplayName("Is Launched")]
        public String is_launched { get; set; }

        [DisplayName("Campaign Image Url")]
        public String campaign_image_url { get; set; }

        [DisplayName("Created At")]
        public String created_at { get; set; }

        [DisplayName("Launch Date")]
        public String launch_date { get; set; }

        [DisplayName("Campaign Hearts")]
        public String campaign_hearts { get; set; }

        [DisplayName("Cocial Share Total")]
        public String social_share_total { get; set; }

        [DisplayName("Social Share Last Update")]
        public String social_share_last_update { get; set; }

        [DisplayName("Location City")]
        public String location_city { get; set; }

        [DisplayName("Location Country")]
        public String location_country { get; set; }

        [DisplayName("Location Zip")]
        public String location_zip { get; set; }

        [DisplayName("Is Charity")]
        public String is_charity { get; set; }

        [DisplayName("Charity Valid")]
        public String charity_valid { get; set; }

        //[DisplayName("Charity Npo Id")]
        //public string charity_npo_id { get; set; }

        //[DisplayName("Charity Name")]
        //public string charity_name { get; set; }

        [DisplayName("Velocity")]
        public String velocity { get; set; }

    }
}
