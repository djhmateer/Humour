using AutoMapper;
using Humour.Infrastructure;
using Humour.Model;
using Humour.Model.Repositories;
using Humour.Mvc.Models;
using Humour.Mvc.Models.Story;
using Humour.Respository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;
using System.Web.Mvc;

namespace Humour.Mvc.Controllers
{
    public class StoryController : Controller
    {
        private readonly IStoryRepository _storyRepository;
        //private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        const int PageSize = 10;

        public StoryController(IStoryRepository storyRepository)
        {
            _storyRepository = storyRepository;
        }

        // Constructor based DI
        //public StoryController()
        //{
        //    _storyRepository = new StoryRepository();
        //}

        public ActionResult Index(int page = 1, string sort = "Id", string sortDir = "ASC")
        {
            // Use LocalDB for Entity Framework by default
            // Totally need to get rid of this.. why is web config not working.. naming?
            Database.DefaultConnectionFactory = new SqlConnectionFactory("Data Source=(localdb)\\v11.0; Integrated Security=True; MultipleActiveResultSets=True");
            HumourContextInitializer.Init(true);

            int totalRecords = _storyRepository.FindAll().Count();
            var data = new List<DisplayStory>();
            IQueryable<Story> allStories = _storyRepository.FindAll()
                    .OrderBy(string.Format("{0} {1}", sort, sortDir));
                    //.Skip((page * PageSize) - PageSize)
                    //.Take(PageSize);

            Mapper.Map(allStories, data);
            var model = new PagerModel<DisplayStory> { Data = data, PageNumber = page, PageSize = PageSize, TotalRows = totalRecords };
            return View(model);
        }
	}
}