using DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.APIBusiness.DBContext.Interface
{
    public interface ITicketRepository
    {
        EntityBaseResponse GetTicketId(int id);
        EntityBaseResponse PutTicket(string CodigoQR, DateTime Fecha_de_generacion, string Estado, DateTime Fecha_de_vencimiento, int Id_Oferta, int Id_Usuario, int Id_Evento);

    }
}
