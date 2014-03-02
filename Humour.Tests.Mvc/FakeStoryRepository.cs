using Humour.Model;
using Humour.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Humour.Tests.Mvc
{
    internal class FakeStoryRepository : IStoryRepository
    {
        public IQueryable<Story> FindAll(params Expression<Func<Story, object>>[] includeProperties)
        {
            var temp = new List<Story>();
            for (int i = 2; i < 23; i++)
            {
                temp.Add(new Story { Title = i.ToString(), Content = i.ToString(), Id = i + 1 });
            }
            temp.Insert(11, new Story { Title = "1 the first title", Content = "a first content", Id = 24 });
            return temp.AsQueryable();
        }

        public void Add(Story entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Story entity)
        {
            throw new NotImplementedException();
        }

        public Story FindById(int id, params Expression<Func<Story, object>>[] includeProperties)
        {
            return FindAll().SingleOrDefault(x => x.Id == id);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Story> FindByLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Story> FindAll(Expression<Func<Story, bool>> predicate, params Expression<Func<Story, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Story> FindByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
