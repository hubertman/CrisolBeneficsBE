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
        EntityBaseResponse PutTicket(EntityTicket ticket);
    }
}
