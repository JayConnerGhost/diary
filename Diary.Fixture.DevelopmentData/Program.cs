using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diary.Database;
using Diary.Models;

namespace Diary.Fixture.DevelopmentData
{
    class Program
    {
        private static ApplicationUser applicationUser;
        static void Main(string[] args)
        {
            SetUpDevelopmentUser();
            SetUpDevelopmentEntries();
        }

        private static void SetUpDevelopmentEntries()
        {
            using (var context = new DiaryContext())
            {
                context.Entries.Add(new EntryModel());
            }
        }

        private static void SetUpDevelopmentUser()
        {
            applicationUser = new ApplicationUser();
            using (var context = new DiaryContext())
            {
                context.Users.Add(applicationUser);
                context.SaveChanges();
            }
        }
    }
}
