using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Models;

namespace WebDeveloper.Areas.Personal.Controllers
{
    [Authorize]
    public class PersonalController : Controller
    {
        private readonly PersonRepository _personalRepository;
        public PersonalController(PersonRepository personalRepository)
        {
            _personalRepository = personalRepository;
        }

        public ActionResult Index()
        {
            return View(_personalRepository.GetListDto());
        }

        public PartialViewResult EmailList(int? id)
        {
            if(!id.HasValue) return null;
            return PartialView("_EmailList",_personalRepository.EmailList(id.Value));
        }

        public PartialViewResult Create()
        {
            return PartialView("_Create");
        }

    }
}