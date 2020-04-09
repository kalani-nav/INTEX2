using INTEX2.DAL;
using INTEX2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEX2.Controllers
{
    public class HomeController : Controller
    {
        private Intex2Context db = new Intex2Context();
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<Campaign> campaigns =
                db.Database.SqlQuery<Campaign>("SELECT C.id, C.url, C.campaign_id, C.auto_fb_post_mode, C.collected_date," +
                "                               C.category_id, C.category, C.currencycode, C.current_amount, C.goal, C.donators," +
                "                               C.days_active, C.days_created, C.title, C.description, C.default_url, " +
                "                               C.has_beneficiary, C.media_type, C.project_type, C.turn_off_donations, C.user_id, " +
                "                               C.user_first_name, C.user_last_name, C.user_facebook_id, C.user_profile_url, C.visible_in_search, " +
                "                               C.status, C.deactivated, C.state, C.is_launched, C.campaign_image_url, C.created_at, " +
                "                               C.launch_date, C.campaign_hearts, C.social_share_total, C.social_share_last_update, " +
                "                               C.location_city, C.location_country, C.location_zip, C.is_charity, C.charity_valid, " +
                "                               C.velocity " +
                                                "FROM Campaigns C " +
                                                "WHERE id BETWEEN 1 AND 9");

            return View(campaigns);
        }
    }
}