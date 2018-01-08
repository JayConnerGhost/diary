﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diary.Models;
using NSubstitute;
using Xunit;

namespace DiaryWeb.Tests
{
    public class CreateEntrySpecifications
    {
        [Fact]
        public void TitleCanBeSet()
        {
            //arrange
            const string actualTitle="article title";
            const string expectedTitle="article title";
            var entryModel = Substitute.For<IEntryModel>();
            entryModel.Title.Returns(actualTitle);
            
            //act+assert
            Assert.Equal(expectedTitle,entryModel.Title);
        }

        [Fact]
        public void PublishDateCanBeSet()
        {
            //arrange
            var expectedDate=new DateTime(1,1,1);
            var actualPublishDate=new DateTime(1,1,1);
            var entryModel=Substitute.For<IEntryModel>();
            entryModel.PublishDate.Returns(actualPublishDate);

            //act+assert
            Assert.Equal(expectedDate,entryModel.PublishDate);
        }

        [Fact]
        public void TagCanBeSet()
        {
            //arrange

            const string expectedContent="#Fishing";
            var entryModel=Substitute.For<IEntryModel>();
            var actualTag=Substitute.For<ITag>();
            actualTag.Content.Returns(expectedContent);
            entryModel.Tags.Returns(new List<ITag>(){actualTag});
            
            //act+assert
            Assert.Equal(expectedContent,entryModel.Tags.First().Content);
        }

        [Fact]
        public void MultipleTagsCanBeSet()
        {
            const int expectedCount=3;
            //arrange
            IEntryModel entry=new EntryModel();
            entry.Tags.Add(new Tag());
            entry.Tags.Add(new Tag());
            entry.Tags.Add(new Tag());

            //act+assert
            var actualCount=entry.Tags.Count;
            Assert.Equal(expectedCount,actualCount);
        }

    }
}
