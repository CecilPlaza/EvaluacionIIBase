using LibreriaEvaluacion.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEvaluacion.DAL
{
    public class PrestamoDAL
    {
        // ToDo: métodos
        PrestamoDAL prestamoDal = new PrestamoDAL();

        public bool Insertar(PrestamoDTO dato)
        {
            return PrestamoDTO.Add(dato);
        }

        public List<PrestamoDTO> Listar()
        {
            return PrestamoDTO.datos;
            
        }

    }
}
