using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using INTEX2.Data;
using INTEX2.Models;

namespace INTEX2.Controllers
{
    public class CampaignsController : Controller
    {
        private INTEX2Context db = new INTEX2Context();

        // GET: Campaigns
        public ActionResult Index()
        {
            return View(db.Campaigns.ToList());
        }

        // GET: Campaigns/Details/5
        public ActionResult Details(int? id)
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

        // GET: Campaigns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Campaigns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "campaign_id,url,auto_fb_post_mode,collected_date,category_id,category,currencycode,current_amount,goal,donators,days_active,days_created,title,description,default_url,has_beneficiary,media_type,project_type,turn_off_donations,user_id,user_first_name,user_last_name,user_facebook_id,user_profile_url,visible_in_search,status,deactivated,state,is_launched,campaign_image_url,created_at,launch_date,campaign_hearts,social_share_total,social_share_last_update,location_city,location_country,location_zip,is_charity,charity_valid,charity_npo_id,charity_name,velocity")] Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                db.Campaigns.Add(campaign);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(campaign);
        }

        // GET: Campaigns/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Campaigns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "campaign_id,url,auto_fb_post_mode,collected_date,category_id,category,currencycode,current_amount,goal,donators,days_active,days_created,title,description,default_url,has_beneficiary,media_type,project_type,turn_off_donations,user_id,user_first_name,user_last_name,user_facebook_id,user_profile_url,visible_in_search,status,deactivated,state,is_launched,campaign_image_url,created_at,launch_date,campaign_hearts,social_share_total,social_share_last_update,location_city,location_country,location_zip,is_charity,charity_valid,charity_npo_id,charity_name,velocity")] Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                db.Entry(campaign).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(campaign);
        }

        // GET: Campaigns/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: Campaigns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
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
