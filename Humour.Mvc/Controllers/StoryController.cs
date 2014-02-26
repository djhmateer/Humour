using Humour.Infrastructure;
using Humour.Model;
using Humour.Model.Repositories;
using Humour.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public StoryController()
        {
            _storyRepository = new StoryRepository();
        }

        public ActionResult Index(int page = 1, string sort = "Id", string sortDir = "ASC")
        {
            int totalRecords = _storyRepository.FindAll().Count();
            //var data = new List<DisplayStory>();
            //IQueryable<Story> allStories = _storyRepository.FindAll().OrderBy(BuildOrderBy(sort, sortDir)).Skip((page * PageSize) - PageSize).Take(PageSize);
            IQueryable<Story> allStories = _storyRepository.FindAll().OrderBy(x => x.Title);
            //Mapper.Map(allPeople, data);
            //var model = new PagerModel<DisplayPerson> { Data = data, PageNumber = page, PageSize = PageSize, TotalRows = totalRecords };
            return View(allStories);
            //return null;
        }
	}
}