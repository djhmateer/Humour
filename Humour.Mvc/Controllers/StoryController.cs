using AutoMapper;
using Humour.Infrastructure;
using Humour.Model;
using Humour.Model.Repositories;
using Humour.Mvc.Models;
using Humour.Mvc.Models.Story;
using Humour.Respository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
            return View(data);
        }

	}
}