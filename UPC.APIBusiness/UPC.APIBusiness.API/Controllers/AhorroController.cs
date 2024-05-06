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
using UPC.APIBusiness.DBContext.Interface;

namespace API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [Route("api/Ahorro")]
    public class AhorroController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IAhorroRepository _ahorroRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ahorroRepository"></param>
        public AhorroController(IAhorroRepository ahorroRepository)
        {
            _ahorroRepository = ahorroRepository;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("obtenerAhorro")]

        public ActionResult GetAhorro(int idUsuario)
        {
            var rest = _ahorroRepository.GetAhorroUsuario(idUsuario);
            return Json(rest);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="ahorro"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("ActualizaAhorro")]

        public ActionResult UpdAhorro(int idUsuario, double ahorro)
        {
            var rest = _ahorroRepository.UpdateAhorroUsuario(idUsuario, ahorro);
            return Json(rest);
        }
    }
}