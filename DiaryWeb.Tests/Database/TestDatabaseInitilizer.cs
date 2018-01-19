using System.Data.Entity;
using Diary.Models;

namespace DiaryWeb.Tests.Database
{
    public class TestDatabaseInitilizer : DropCreateDatabaseAlways<DiaryContext>
    {

    }
}