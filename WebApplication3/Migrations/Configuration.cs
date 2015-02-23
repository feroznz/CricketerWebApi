using System.Collections.Generic;
using CricketersWebApi.DAL;
using WebApplication3.DAL.Entities;

namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StatsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StatsDbContext context)
        {
            //var t1 = new Team { Name = "Adelaide Strikers", CreatedDate = DateTime.Now, Players = new List<Player> { }, UpdatedDate = DateTime.Now };
            //var t2 = new Team { Name = "Brisbane Heat", CreatedDate = DateTime.Now, Players = new List<Player> { }, UpdatedDate = DateTime.Now };
            //var t3 = new Team { Name = "Hobart Hurricanes", CreatedDate = DateTime.Now, Players = new List<Player> { }, UpdatedDate = DateTime.Now };

            //var t4 = new Team { Name = "Melbourne Renegades", CreatedDate = DateTime.Now, Players = new List<Player> { }, UpdatedDate = DateTime.Now };
            //var t5 = new Team { Name = "Melbourne Stars", CreatedDate = DateTime.Now, Players = new List<Player> { }, UpdatedDate = DateTime.Now };
            //var t6 = new Team { Name = "Sydney Sixers", CreatedDate = DateTime.Now, Players = new List<Player> { }, UpdatedDate = DateTime.Now };
            //var t7 = new Team { Name = "Sydney Thunder", CreatedDate = DateTime.Now, Players = new List<Player> { }, UpdatedDate = DateTime.Now };
            //var t8 = new Team { Name = "Perth Scorchers", CreatedDate = DateTime.Now, Players = new List<Player> { }, UpdatedDate = DateTime.Now };

            //context.Teams.AddOrUpdate(t1);
            //context.Teams.AddOrUpdate(t2);
            //context.Teams.AddOrUpdate(t3);

            //context.Teams.AddOrUpdate(t4);
            //context.Teams.AddOrUpdate(t5);
            //context.Teams.AddOrUpdate(t6);
            //context.Teams.AddOrUpdate(t7);
            //context.Teams.AddOrUpdate(t8);
        }
    }
}
