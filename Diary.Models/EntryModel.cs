using System;
using System.Collections.Generic;

namespace Diary.Models
{
    public class EntryModel : IEntryModel
    {
        public EntryModel()
        {
            Tags=new List<ITag>();
        }

        public string Title { get; set; }
        public DateTime? PublishDate { get; set; }
        public ICollection<ITag> Tags { get; set; }
        public string Content { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual int Id { get; set; }
    }
}