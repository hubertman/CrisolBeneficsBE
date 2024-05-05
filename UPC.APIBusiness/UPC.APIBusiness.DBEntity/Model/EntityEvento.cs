using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntity
{
    public class EntityEvento : EntityBase
    {
        public int Id_Evento { get; set; }
        public string NombreEvento { get; set; }
        public string DescripcionEvento { get; set; }
        public string UbicacionEvento { get; set; }
        public int CapacidadMaximaEvento { get; set; }
        public int CapacidadActualEvento { get; set; }
    }
}
