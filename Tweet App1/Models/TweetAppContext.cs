using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace com.tweetapp.Models
{
    class TweetAppContext : DbContext
    {
        public TweetAppContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LTIN291237;Initial Catalog=TweetAppDb;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<UserCred> UserCreds { get; set; }
    }
}
