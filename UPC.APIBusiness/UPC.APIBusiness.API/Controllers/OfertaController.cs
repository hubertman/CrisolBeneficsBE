using DBContext;
using DBEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NSwag.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [Route("api/oferta")]
    public class OfertaController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IOfertaRepository _ofertaRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ofertaRepository"></param>
        public OfertaController(IOfertaRepository ofertaRepository)
        {
            _ofertaRepository = ofertaRepository;
        }

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetOfertas()
        {
            var rest = _ofertaRepository.GetOfertas();
            return Json(rest);
        }

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listarporId")]
        public ActionResult GetOfertaId(int id)
        {
            var rest = _ofertaRepository.GetOfertaId(id);
            return Json(rest);
        }
    }
}
