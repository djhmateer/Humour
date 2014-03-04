using AutoMapper;
using Humour.Infrastructure;
using Humour.Model;
using Humour.Model.Repositories;
using Humour.Mvc.Models;
using Humour.Mvc.Models.Story;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web.Mvc;

namespace Humour.Mvc.Controllers
{
    public class StoryController : Controller
    {
        private readonly IStoryRepository _storyRepository;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        const int PageSize = 100;

        public StoryController(IStoryRepository storyRepository, IUnitOfWorkFactory unitOfWorkFactory)
        {
            _storyRepository = storyRepository;
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public ActionResult Index(int page = 1, string sort = "Rating", string sortDir = "DESC")
        {
            int totalRecords = _storyRepository.FindAll().Count();
            var data = new List<DisplayStory>();

            // Using DynamicQuery to order by a string
            IQueryable<Story> allStories = _storyRepository.FindAll()
                    .OrderBy(string.Format("{0} {1}", sort, sortDir));

            //Mapper.Map(allStories, data);
            foreach (var story in allStories)
            {
                var data1 = new DisplayStory();
                data1.Id = story.Id;
                data1.DateCreated = story.DateCreated;
                data1.Title = story.Title;
                data1.Content = story.Content;
                data1.VideoURL = story.VideoURL;
                data1.ImageURL = story.ImageURL;
                data1.Rating = story.Rating;
                data.Add(data1);
            }

            var model = new PagerModel<DisplayStory> { Data = data, PageNumber = page, PageSize = PageSize, TotalRows = totalRecords };
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateAndEditStory createAndEditStory)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {
                        var story = new Story();
                        Mapper.Map(createAndEditStory, story);
                        _storyRepository.Add(story);
                        return RedirectToAction("Index");
                    }
                }
                catch (ModelValidationException mvex)
                {
                    foreach (var error in mvex.ValidationErrors)
                    {
                        ModelState.AddModelError(error.MemberNames.FirstOrDefault() ?? "", error.ErrorMessage);
                    }
                }
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            Story story = _storyRepository.FindById(id);
            if (story == null)
            {
                return HttpNotFound();
            }
            var data = new CreateAndEditStory();
            Mapper.Map(story, data);
            //data.Id = story.Id;
            //data.Title = story.Title;
            //data.Content = story.Content;
            //data.VideoURL = story.VideoURL;
            //data.ImageURL = story.ImageURL;
            //data.Rating = story.Rating;

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CreateAndEditStory createAndEditStory)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (_unitOfWorkFactory.Create())
                    {
                        Story storyToUpdate = _storyRepository.FindById(createAndEditStory.Id);
                        Mapper.Map(createAndEditStory, storyToUpdate, typeof(CreateAndEditStory), typeof(Story));
                        return RedirectToAction("Index");
                    }
                }
                catch (ModelValidationException mvex)
                {
                    foreach (var error in mvex.ValidationErrors)
                    {
                        ModelState.AddModelError(error.MemberNames.FirstOrDefault() ?? "", error.ErrorMessage);
                    }
                }
            }
            return View();
        }
	}
}