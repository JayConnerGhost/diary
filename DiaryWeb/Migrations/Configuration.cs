using Diary.Models;
using Microsoft.AspNet.Identity;

namespace DiaryWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Diary.Models.DiaryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Diary.Models.DiaryContext context)
        {
            var passwordHash = new PasswordHasher();
            string password = passwordHash.HashPassword("Password@123");
            var applicationUser = new ApplicationUser
            {
                UserName = "jayconnerghost@gmail.com",
                PasswordHash = password,
                PhoneNumber = "08869879"
            };
            context.Users.AddOrUpdate(u => u.UserName, applicationUser);
            
            context.Entries.AddOrUpdate(e=>e.Id,new EntryModel()
            {
                Id = 1,
                PublishDate=DateTime.Now,
                Content="this is a test entry for the diary , article 1",
                Title="test article 1",
                ApplicationUser = applicationUser
            });

            context.Entries.AddOrUpdate(e => e.Id, new EntryModel()
            {
                Id = 2,
                PublishDate = DateTime.Now,
                Content = "this is a test entry for the diary , article 2",
                Title = "test article 2",
                ApplicationUser = applicationUser
            });

            context.Entries.AddOrUpdate(e => e.Id, new EntryModel()
            {
                Id = 3,
                PublishDate = DateTime.Now,
                Content = "this is a test entry for the diary , article 3",
                Title = "test article 3",
                ApplicationUser = applicationUser
            });

            context.Entries.AddOrUpdate(e => e.Id, new EntryModel()
            {
                Id = 4,
                PublishDate = DateTime.Now,
                Content = "this is a test entry for the diary , article 4",
                Title = "test article 4",
                ApplicationUser = applicationUser
            });

            context.Entries.AddOrUpdate(e => e.Id, new EntryModel()
            {
                Id = 5,
                PublishDate = DateTime.Now,
                Content = "this is a test entry for the diary , article 5",
                Title = "test article 5",
                ApplicationUser = applicationUser
            });

        }
    }
}
