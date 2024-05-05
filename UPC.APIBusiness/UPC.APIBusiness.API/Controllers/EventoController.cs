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
    [Route("api/evento")]
    public class EventoController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IEventoRepository _eventoRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventoRepository"></param>
        public EventoController(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetEventos()
        {
            var rest = _eventoRepository.GetEventos();
            return Json(rest);
        }

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listarporId")]
        public ActionResult GetEventoId(int id)
        {
            var rest = _eventoRepository.GetEventoId(id);
            return Json(rest);
        }
    }
}
