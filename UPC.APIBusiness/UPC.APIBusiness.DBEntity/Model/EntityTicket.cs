using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntity
{
    public class EntityTicket : EntityBase
    {
        public int Id_Ticket { get; set; }
        public string Codigo_QR { get; set; }
        public DateTime Fecha_de_generacion { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_de_vencimiento { get; set; }
        public int Id_Oferta { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Evento { get; set; }
    }
}
