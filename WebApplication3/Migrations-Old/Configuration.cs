using System.Collections.Generic;
using WebApplication3.DAL;
using WebApplication3.DAL.Entities;

namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication3.DAL.StatsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StatsDbContext context)
        {
            var p1 = new Player { FirstName = "Kevin", LastName = "Pietersen", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p2 = new Player { FirstName = "Aaron", LastName = "Finch", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p3 = new Player { FirstName = "Chris", LastName = "Lyn", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p4 = new Player { FirstName = "Johan", LastName = "Botha", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p5 = new Player { FirstName = "Cameron", LastName = "White", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p6 = new Player { FirstName = "George", LastName = "Bailey", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p7 = new Player { FirstName = "Brad", LastName = "Haddin", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p8 = new Player { FirstName = "James", LastName = "Hopes", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p9 = new Player { FirstName = "Yasir", LastName = "Arafat", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p10 = new Player { FirstName = "Usman", LastName = "Khawaja", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };

            var t1 = new Team { Name = "Melbourne Stars", CreatedDate = DateTime.Now, Players = new List<Player> { p1, p5 }, UpdatedDate = DateTime.Now };
            var t2 = new Team { Name = "Melbourne Renegades", CreatedDate = DateTime.Now, Players = new List<Player> { p2 }, UpdatedDate = DateTime.Now };
            var t3 = new Team { Name = "Adelaide Strikers", CreatedDate = DateTime.Now, Players = new List<Player> { p4 }, UpdatedDate = DateTime.Now };
            var t4 = new Team { Name = "Brisbane Heat", CreatedDate = DateTime.Now, Players = new List<Player> { p3, p8 }, UpdatedDate = DateTime.Now };
            var t5 = new Team { Name = "Sydney Sixers", CreatedDate = DateTime.Now, Players = new List<Player> { p7 }, UpdatedDate = DateTime.Now };
            var t6 = new Team { Name = "Hobart Hurricanes", CreatedDate = DateTime.Now, Players = new List<Player> { p6 }, UpdatedDate = DateTime.Now };
            var t7 = new Team { Name = "Perth Scorchers", CreatedDate = DateTime.Now, Players = new List<Player> { p10 }, UpdatedDate = DateTime.Now };
            var t8 = new Team { Name = "Sydney Thunder", CreatedDate = DateTime.Now, Players = new List<Player> { p9 }, UpdatedDate = DateTime.Now };


            p1.Team = t1;
            p2.Team = t2;
            p3.Team = t4;
            p4.Team = t3;
            p5.Team = t1;
            p6.Team = t6;
            p7.Team = t5;
            p8.Team = t4;
            //p9.Team = t7;
            //p10.Team = t8;

            var game = new Game { AwayTeam = t1, HomeTeam = t2, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, StartTime = DateTime.Now };

            context.Players.AddOrUpdate(p1);
            context.Players.AddOrUpdate(p2);
            context.Players.AddOrUpdate(p3);
            context.Players.AddOrUpdate(p4);
            context.Players.AddOrUpdate(p5);
            context.Players.AddOrUpdate(p6);
            context.Players.AddOrUpdate(p7);
            context.Players.AddOrUpdate(p8);
            //context.Players.AddOrUpdate(p9);
            //context.Players.AddOrUpdate(p10);

            context.Teams.AddOrUpdate(t1);
            context.Teams.AddOrUpdate(t2);
            context.Teams.AddOrUpdate(t3);
            context.Teams.AddOrUpdate(t4);
            context.Teams.AddOrUpdate(t5);
            context.Teams.AddOrUpdate(t6);
            context.Teams.AddOrUpdate(t7);
            context.Teams.AddOrUpdate(t8);

            context.Games.AddOrUpdate(game);
        }
    }
}
