using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Webzine.Entity;
using Webzine.Repository.Contracts;

namespace Webzine.WebApplication.Areas.API.Controllers
{
    [ApiController]
    public class TitresController : ControllerBase
    {
        ITitreRepository _titreRepository;

        public TitresController(ITitreRepository titreRepository)
        {
            _titreRepository = titreRepository;
        }

        /// <summary>
        /// Permet de récupérer tout les titres en format Json
        /// </summary>
        /// <returns> Retourne tout les titres dans un format Json </returns>
        [HttpGet]
        [Route("api/Titres")]
        public IActionResult GetTitres()
        {
            try
            { 
                var result = JsonConvert.SerializeObject(_titreRepository.FindAll(), Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        
        /// <summary>
        /// Permet de récupérer un titre grâce à son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Retourne un titre dans un format Json </returns>
        [HttpGet]
        [Route("api/Titres/{id}")]
        public IActionResult GetTitre(int id)
        {
            try
            {
                var result = JsonConvert.SerializeObject(_titreRepository.Find(id), Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("api/Titres")]
        public IActionResult PostTitre([FromBody]Titre titre)
        {
            try
            {
                
                _titreRepository.Add(titre);
                return CreatedAtAction("GetTitre", titre);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        [HttpPut]
        [Route("api/Titres/{id}")]
        public IActionResult EditTitre(Titre titre)
        {
            try
            {
                _titreRepository.Update(titre);
                return CreatedAtAction("GetTitre", titre);
            }
            catch (Exception e)
            {

                return    StatusCode(500, e);
            }
        }
    }
}