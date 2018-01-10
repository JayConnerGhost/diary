using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diary.Database;
using Diary.Models;
using Xunit;
using System.Data.Entity;
using NSubstitute.Core;

namespace DiaryWeb.Tests.Database
{
   public class EntrySpecifications
    {
        [Fact]
        public void CanCreateEntryandRetreiveEntry()
        {
            //arrange
            System.Data.Entity.Database.SetInitializer(new TestDatabaseInitilizer());
            const string title="TestTitle";
            var entry = new EntryModel {Title = title};


            //act
            var storedId=SaveEntryReturnId(entry);
            var returnedEntry=FindEntryBy(storedId);

            //assert
            var actualTitle=returnedEntry.Title;
            Assert.Equal(title, actualTitle);
        }

        private IEntryModel FindEntryBy(int storedId)
        {
            IEntryModel entry;
            using (var context = new DiaryContext())
            {
                entry = context.Entries.Find(storedId);
            }

            return entry;
        }

        private int SaveEntryReturnId(EntryModel entry)
        {
            using (var context = new DiaryContext())
            {
                context.Entries.Add(entry);
                context.SaveChanges();
            }
            return entry.Id;
        }
    }

    public class TestDatabaseInitilizer : DropCreateDatabaseAlways<DiaryContext>
    {

    }
}
