using DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContext
{
    public interface IEventoRepository
    {
        EntityBaseResponse GetEventos();
        EntityBaseResponse GetEventoId(int id);
    }
}
