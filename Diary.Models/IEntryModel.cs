using System;
using System.Collections.Generic;

namespace Diary.Models
{
    public interface IEntryModel
    {
        string Title { get; set; }
        DateTime PublishDate { get; set; }
        ICollection<ITag> Tags { get; set; }
    }
}