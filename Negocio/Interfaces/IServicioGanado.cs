using Entidad;
using System.Collections.Generic;

namespace Negocio.Interfaces
{
    public interface IServicioGanado
    {
        bool Agregar(Ganado ganado);
        List<Ganado> Listar();
        bool Actualizar(int idGanado, Ganado ganado);
        bool Eliminar(Ganado ganado);
    }
}
