using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntity
{
    public class EntityAhorro : EntityBase
    {
        public int Id_Ahorro { get; set; }
        public int Id_Usuario { get; set; }
        public double Valor_Real { get; set; }
        public double Monto_Ahorrado { get; set; }
    }
}