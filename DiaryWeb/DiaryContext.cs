using System.Data.Entity;

namespace Diary.Models
{
    public class DiaryContext: Diary.Models.ApplicationDbContext
    {
        public DbSet<EntryModel> Entries { get; set; }
    }
}
