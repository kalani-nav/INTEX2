using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX2.Models
{
    [Table("Campaigns")]
    public class Campaign
    {
        [DisplayName("id")]
        public int id { get; set; }

        [DisplayName("url")]
        public int url { get; set; }

        [Key]
        [DisplayName("Campaign Id")]
        public int campaign_id { get; set; }

        [DisplayName("Auto FB Post Made")]
        public Boolean auto_fb_post_mode { get; set; }

        [DisplayName("Collected Date")]
        public string collected_date { get; set; }

        [DisplayName("Category Id")]
        public int category_id { get; set; }

        [DisplayName("Category")]
        public string category { get; set; }

        [DisplayName("Currency Code")]
        public string currencycode { get; set; }

        [DisplayName("Current Amount")]
        public int current_amount { get; set; }

        [DisplayName("Goal")]
        public int goal { get; set; }

        [DisplayName("Donators")]
        public int donators { get; set; }

        [DisplayName("Days Active")]
        public int days_active { get; set; }

        [DisplayName("Days Created")]
        public int days_created { get; set; }

        [DisplayName("Title")]
        public string title { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Default URL")]
        public string default_url { get; set; }

        [DisplayName("Has Beneficiary")]
        public Boolean has_beneficiary { get; set; }

        [DisplayName("Media Type")]
        public int media_type { get; set; }

        [DisplayName("Project Type")]
        public int project_type { get; set; }

        [DisplayName("Turn Off Donations")]
        public string turn_off_donations { get; set; }

        [DisplayName("User Id")]
        public int user_id { get; set; }

        [DisplayName("User First Name")]
        public string user_first_name { get; set; }

        [DisplayName("User Last Name")]
        public string user_last_name { get; set; }

        [DisplayName("User Facebook Id")]
        public string user_facebook_id { get; set; }

        [DisplayName("User Profile URL")]
        public string user_profile_url { get; set; }

        [DisplayName("Visible In Search")]
        public Boolean visible_in_search { get; set; }

        [DisplayName("Status")]
        public Boolean status { get; set; }

        [DisplayName("Deactivated")]
        public Boolean deactivated { get; set; }

        [DisplayName("State")]
        public string state { get; set; }

        [DisplayName("Is Launched")]
        public Boolean is_launched { get; set; }

        [DisplayName("Campaign Image Url")]
        public string campaign_image_url { get; set; }

        [DisplayName("Created At")]
        public string created_at { get; set; }

        [DisplayName("Launch Date")]
        public string launch_date { get; set; }

        [DisplayName("Campaign Hearts")]
        public int campaign_hearts { get; set; }

        [DisplayName("Cocial Share Total")]
        public int social_share_total { get; set; }

        [DisplayName("Social Share Last Update")]
        public string social_share_last_update { get; set; }

        [DisplayName("Location City")]
        public string location_city { get; set; }

        [DisplayName("Location Country")]
        public string location_country { get; set; }

        [DisplayName("Location Zip")]
        public string location_zip { get; set; }

        [DisplayName("Is Charity")]
        public Boolean is_charity { get; set; }

        [DisplayName("Charity Valid")]
        public Boolean charity_valid { get; set; }

        //[DisplayName("Charity Npo Id")]
        //public string charity_npo_id { get; set; }

        //[DisplayName("Charity Name")]
        //public string charity_name { get; set; }

        [DisplayName("Velocity")]
        public int velocity { get; set; }

    }
}
