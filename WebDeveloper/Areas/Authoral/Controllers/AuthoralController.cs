using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Areas.Authoral.Controllers
{
    [Authorize]

    public class AuthoralController : Controller
    {
        private readonly AuthorsRepository _authorsRepository;
        public AuthoralController(AuthorsRepository authorsRepository)
        {
            _authorsRepository = authorsRepository;
        }

        [OutputCache(Duration = 0)]
        public ActionResult Index()
        {
            ViewBag.Count = TotalPages(10);
            return View();
        }

        [OutputCache(Duration = 0)]
        public ActionResult List(int? page, int? size)
        {
            if (!page.HasValue || !size.HasValue)
            {
                page = 1;
                size = 10;
            }
            return PartialView("_List", _authorsRepository.GetListDto().Page(page.Value, size.Value));
        }


        public PartialViewResult Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Authors author)
        {
            if (!ModelState.IsValid) return PartialView("_Create", author);
            Random rnd = new Random();
            author.au_id = rnd.Next();
            _authorsRepository.Add(author);
            return new HttpStatusCodeResult(HttpStatusCode.OK); 
        }

        [OutputCache(Duration = 0)]
        public ActionResult Edit(int id)
        {
            var author = _authorsRepository.GetById(id);
            if (author == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Edit", author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [OutputCache(Duration = 0)]
        public ActionResult Edit(Authors authors)
        {
            if (!ModelState.IsValid) return PartialView("_Edit", authors);
            _authorsRepository.Update(authors);
            return RedirectToRoute("authors_default");
        }

        [OutputCache(Duration = 0)]
        public ActionResult Delete(int id)
        {

            var author = _authorsRepository.GetById(id);
            if (author == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Delete", author);

        }

        #region Common Methods
        private int TotalPages(int? size)
        {
            var rows = _authorsRepository.Count();
            var totalPages = rows / size.Value;
            if ((rows % size.Value) != 0)
                totalPages++;
            return totalPages;
        }
        #endregion
    }
}