using DBContext;
using DBEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NSwag.Annotations;
using System;
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
        public ActionResult PutTicketId(
            string codigoQR, DateTime Fecha_de_generacion, string Estado, DateTime Fecha_de_vencimiento,
            int Id_Oferta, int Id_Usuario, int Id_Evento
            )
        {
            var rest = _ticketRepository.PutTicket(codigoQR, Fecha_de_generacion, Estado, Fecha_de_vencimiento, Id_Oferta, Id_Usuario, Id_Evento);
            return Json(rest);
        }
    }
}
