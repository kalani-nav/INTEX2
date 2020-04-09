using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using INTEX2.Models;

namespace INTEX2.DAL
{
    public class Intex2Context : DbContext
    {
        public Intex2Context() : base("Intex2Context")
        {

        }

        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Update> Updates { get; set; }
        public DbSet<User> Users { get; set; }
    }
}