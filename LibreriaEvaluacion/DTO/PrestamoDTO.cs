using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEvaluacion.DTO
{
    public class PrestamoDTO
    {
        // ToDo: atributos
        private int id;
        private int monto;
        public static List<PrestamoDTO> prestamo = new List<PrestamoDTO>()
        { new PrestamoDTO() { id = 1, monto = 100000 },
          new PrestamoDTO() { id = 2, monto = 250000 },
          new PrestamoDTO() { id=3, monto = 150000}
        };
        

            

        // ToDo: propiedades
        public int Id { get => id; set => id = value; }
        public int Monto { get => monto; set => monto = value; }

        // ToDo: métodos
        internal static Add(PrestamoDTO dato)
        { 
        
        }
       
        
    }
}
