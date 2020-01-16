using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.Repository.Contracts;

namespace Webzine.WebApplication.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class PaysController : Controller
    {
        private readonly IPaysRepository _paysRepository;

        public PaysController(IPaysRepository paysRepository)
        {
            this._paysRepository = paysRepository;
        }

        /// <summary>
        ///  Permet de récupérer tout les pays dans notre jeu de données.
        /// </summary>
        /// <returns>La vue index.</returns>
        public IActionResult Index()
        {
            return this.View(this._paysRepository.FindAll());
        }

        /// <summary>
        /// Permet d'afficher la view Create.
        /// </summary>
        /// <returns>La vue create.</returns>
        public IActionResult Create()
        {
            return this.View();
        }

        /// <summary>
        /// Permet de créer un nouveau pays.
        /// </summary>
        /// <param name="pays"></param>
        /// <returns>En cas de réussite retourne sur la page index pays, en cas d'échecs retourne sur la page create pays.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pays pays)
        {
            try
            {
                this._paysRepository.Add(pays);
                return this.RedirectToAction(nameof(Index));
            }
            catch
            {
                return this.View();
            }
        }

        /// <summary>
        /// Permet d'afficher la page edit d'un pays grâce à son id.
        /// </summary>
        /// <param name="id">L'index du pays.</param>
        /// <returns>La vue edit.</returns>
        public IActionResult Edit(int id)
        {
            return this.View(_paysRepository.Find(id));
        }

        /// <summary>
        /// Permet d'editer un pays.
        /// </summary>
        /// <param name="pays">Le pays à modifier.</param>
        /// <returns>En cas de réussite retourne sur la page index pays, en cas d'échecs retourne sur la page edit pays.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pays pays)
        {
            try
            {
                this._paysRepository.Update(pays);
                return this.RedirectToAction(nameof(Index));
            }
            catch
            {
                return this.View();
            }
        }

        /// <summary>
        /// Permet d'afficher la vue delete pays grâce à son id.
        /// </summary>
        /// <param name="id">L'index du pays.</param>
        /// <returns>La vue delete pays.</returns>
        public IActionResult Delete(int id)
        {
            return this.View(_paysRepository.Find(id));
        }

        /// <summary>
        /// Permet de supprimer un pays.
        /// </summary>
        /// <param name="pays">Le pays à supprimer.</ param >
        /// <returns>En cas de réussite retourne sur la page index pays, en cas d'échecs retourne sur la page delete pays.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Pays pays)
        {
            try
            {
                this._paysRepository.Delete(pays);
                return this.RedirectToAction(nameof(Index));
            }
            catch
            {
                return this.View();
            }
        }
    }
}