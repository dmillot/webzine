using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Webzine.Repository.Contracts;

namespace Webzine.WebApplication.Areas.API.Controllers
{
    
    [ApiController]
    public class ArtistesController : ControllerBase
    {
        IArtisteRepository _artisteRepository;

        public ArtistesController(IArtisteRepository artisteRepository)
        {
            this._artisteRepository = artisteRepository;
        }

        /// <summary>
        /// Permet de récupérer tous les artistes.
        /// </summary>
        /// <returns>La liste des artistes.</returns>
        [HttpGet]
        [Route("api/artistes")]
        public IActionResult GetArtiste()
        {
            try
            {
                var result = JsonConvert.SerializeObject(_artisteRepository.FindAll(), Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
    }
}