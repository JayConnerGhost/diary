using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diary.Models;

namespace Diary.Database
{
    public class DiaryContext: Diary.Models.ApplicationDbContext
    {
        public DbSet<EntryModel> Entries { get; set; }
    }
}
