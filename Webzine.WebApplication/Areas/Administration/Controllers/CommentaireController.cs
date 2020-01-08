using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.Repository.Contracts;
using Webzine.WebApplication.Areas.Administration.ViewModels;

namespace Webzine.WebApplication.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class CommentaireController : Controller
    {
        private ICommentaireRepository _commentaireRepository;
        public CommentaireController(ICommentaireRepository commentaireRepository)
        {
            _commentaireRepository = commentaireRepository;
        }

        public IActionResult Index()
        {
            CommentViewModel model = new CommentViewModel()
            {
                Comments = _commentaireRepository.FindAll().ToList()
            };
            return View(model);
        }

        [HttpPost]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _commentaireRepository.Delete(_commentaireRepository.FindAll().FirstOrDefault(c=>c.IdCommentaire==id));
            return Redirect("/administration/commentaires");
        }
    }
}