using DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.APIBusiness.DBEntity.Model
{
    public class EntityOferta : EntityBase
    {
        public int Id_oferta { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public string Descuento { get; set; }
        public string Categoria { get; set; }
        public double Precio_Original { get; set; }
    }
}
