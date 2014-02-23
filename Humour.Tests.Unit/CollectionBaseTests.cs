using FluentAssertions;
using Humour.Model;
using Humour.Model.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Humour.Tests.Unit
{
    [TestClass]
    public class CollectionBaseTests
    {
        [TestMethod]
        public void NewCollectionUsingNewListsAddsValues()
        {
            var collection = new IntCollection(new List<int> { 1, 2, 3 });
            collection.Count.Should().Be(3);
        }

        [TestMethod]
        public void NewCollectionUsingExistingCollectionAddsValues()
        {
            var collection1 = new IntCollection(new List<int> { 1, 2, 3 });
            var collection2 = new IntCollection(collection1);
            collection2.Count.Should().Be(3);
        }

        [TestMethod]
        public void UsingAddRangeAddsValues()
        {
            var collection1 = new IntCollection(new List<int> { 1, 2, 3 });
            var collection2 = new IntCollection();
            collection2.AddRange(collection1);
            collection2.Count.Should().Be(3);
        }

        [TestMethod]
        public void SortPeopleWithSpecifiedComparerSortsCorrectly()
        {
            var stories = new Stories();
            stories.Add(new Story { Title = "asdf", Content = "hello" });
            stories.Add(new Story { Title = "asdf3", Content = "hello" });
            stories.Add(new Story { Title = "asdf2", Content = "hello" });
            stories.Add(new Story { Title = "asdf1", Content = "hello" });
            stories.Add(new Story { Title = "asdf9", Content = "hello" });

            stories.Sort(new StoryComparer());

            stories[0].Title.Should().Be("asdf");
            stories[1].Title.Should().Be("asdf1");
            stories[2].Title.Should().Be("asdf2");
            stories[3].Title.Should().Be("asdf3");
        }

        [TestMethod]
        public void SortIntsSorts()
        {
            var ints = new IntCollection { 3, 2, 1 };
            ints.Sort();
            ints[0].Should().Be(1);
            ints[1].Should().Be(2);
            ints[2].Should().Be(3);
        }

        //[TestMethod]
        //public void AddRangeThrowsWhenCollectionIsNull()
        //{
        //    Action act = () =>
        //    {
        //        var collection = new IntCollection();
        //        collection.AddRange(null);
        //    };
        //    act.ShouldThrow<ArgumentNullException>().WithMessage("collection is null", ComparisonMode.Substring);
        //}
    }

    internal class IntCollection : CollectionBase<int>
    {
        public IntCollection()
        { }

        public IntCollection(IList<int> initialList)
            : base(initialList)
        { }

        public IntCollection(CollectionBase<int> initialList)
            : base(initialList)
        { }
    }

    //public class PersonComparer : IComparer<Person>
    //{
    //    public int Compare(Person x, Person y)
    //    {
    //        return x.FullName.CompareTo(y.FullName);
    //    }
    //}
}
