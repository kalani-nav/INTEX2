using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using INTEX2.DAL;
using INTEX2.Models;

namespace INTEX2.Controllers
{
    public class Campaigns1Controller : Controller
    {
        private Intex2Context db = new Intex2Context();


        // GET: Campaigns1
        //[Authorize]
        public ActionResult Index()
        {
            var checkSearch =
            db.Database.SqlQuery<Campaign>(
            "Select TOP 1 PERCENT * " +
            "FROM covid19_campaigns8 ");

            if (checkSearch.Count() > 0)
            {
                return View("Index", checkSearch.ToList());
            }
            else
            {
                return View("Index", db.Campaigns.ToList());
            }

            return View(db.Campaigns.ToList());
        }



        //[HttpGet]
        //public ActionResult PastWorkOrders() //displays all work orders, no matter the status
        //{
        //    return View(db.Campaigns.ToList());
        //}

        [HttpPost]
        public ActionResult SearchCampByKey(FormCollection form)//searches database for the keyword searched by the user
        {
            String search = form["Search"].ToString();

            //searches for title key word in table
            var checkSearch =
            db.Database.SqlQuery<Campaign>(
            "Select * " +
            "FROM covid19_campaigns8 " +
            "WHERE title LIKE '%" + search + "%'");


            if (checkSearch.Count() > 0)
            {
                return View("Index", checkSearch.ToList());
            }
            else
            {
                return View("Index", db.Campaigns.ToList());
            }

        }


        [HttpPost]
        public ActionResult SearchCampByFLName(FormCollection form)//searches database for the creator searched by the user
        {
            String First = form["FirstName"].ToString();
            String Last = form["LastName"].ToString();

            //searches for first and last name in customer table
            var FirstLastCheck =
                db.Database.SqlQuery<Campaign>(
                    "SELECT * " +
                    "FROM covid19_campaigns8 " +
                    "WHERE (user_first_name = '" + First + "' AND user_last_name = '" + Last + "') OR " +
                    "(user_first_name = '" + First + "' OR user_last_name = '" + Last + "')");

            if (FirstLastCheck.Count() > 0)
            {
                return View("Index", FirstLastCheck.ToList());
            }
            else
            {
                return View("Index", db.Campaigns.ToList());
            }

        }









        // GET: Campaigns1/Details/5
        //[Authorize]
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campaign campaign = db.Campaigns.Find(id);
            if (campaign == null)
            {
                return HttpNotFound();
            }
            return View(campaign);
        }

        // GET: Campaigns1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Campaigns1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "campaign_id,id,url,auto_fb_post_mode,collected_date,category_id,category,currencycode,current_amount,goal,donators,days_active,days_created,title,description,default_url,has_beneficiary,media_type,project_type,turn_off_donations,user_id,user_first_name,user_last_name,user_facebook_id,user_profile_url,visible_in_search,status,deactivated,state,is_launched,campaign_image_url,created_at,launch_date,campaign_hearts,social_share_total,social_share_last_update,location_city,location_country,location_zip,is_charity,charity_valid,velocity")] Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                db.Campaigns.Add(campaign);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(campaign);
        }

        // GET: Campaigns1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campaign campaign = db.Campaigns.Find(id);
            if (campaign == null)
            {
                return HttpNotFound();
            }
            return View(campaign);
        }

        // POST: Campaigns1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "campaign_id,id,url,auto_fb_post_mode,collected_date,category_id,category,currencycode,current_amount,goal,donators,days_active,days_created,title,description,default_url,has_beneficiary,media_type,project_type,turn_off_donations,user_id,user_first_name,user_last_name,user_facebook_id,user_profile_url,visible_in_search,status,deactivated,state,is_launched,campaign_image_url,created_at,launch_date,campaign_hearts,social_share_total,social_share_last_update,location_city,location_country,location_zip,is_charity,charity_valid,velocity")] Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                db.Entry(campaign).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(campaign);
        }

        // GET: Campaigns1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campaign campaign = db.Campaigns.Find(id);
            if (campaign == null)
            {
                return HttpNotFound();
            }
            return View(campaign);
        }

        // POST: Campaigns1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Campaign campaign = db.Campaigns.Find(id);
            db.Campaigns.Remove(campaign);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
