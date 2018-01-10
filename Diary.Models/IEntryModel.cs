using System;
using System.Collections.Generic;
using DiaryWeb.Models;

namespace Diary.Models
{
    public interface IEntryModel
    {
        string Title { get; set; }
        DateTime PublishDate { get; set; }
        ICollection<ITag> Tags { get; set; }
        string Content { get; set; }
        ApplicationUser ApplicationUser { get; set; }
    }
}