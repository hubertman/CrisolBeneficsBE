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
    [Route("api/ticket")]
    public class TicketController : Controller
    {
        protected readonly ITicketRepository _ticketRepository;
        public TicketController(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listarporId")]
        public ActionResult GetTicketId(int id)
        {
            var rest = _ticketRepository.GetTicketId(id);
            return Json(rest);
        }


        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("Insertar")]
        public ActionResult PutTicketId(EntityTicket ticket)
        {
            var rest = _ticketRepository.PutTicket(ticket);
            return Json(rest);
        }
    }
}
