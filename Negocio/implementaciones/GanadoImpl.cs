using Datos.Repositorios;
using Entidad;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;

namespace Negocio.implementaciones
{
    public class GanadoImpl : IServicioGanado
    {
        public static List<Ganado> ganados;
        RepoGanado repoGanado;

        public GanadoImpl()
        {
            repoGanado = new RepoGanado("ganado.txt");
            ganados = repoGanado.GetGanados();
        }

        public bool Actualizar(int idGanado, Ganado ganado)
        {
            try
            {
                Ganado g = new Ganado();
                g.IdGanado = ganado.IdGanado;
                g.Raza = ganado.Raza;
                g.Sexo = ganado.Sexo;
                g.Peso = ganado.Peso;
                g.Meses = ganado.Meses;
                g.PesoVenta = ganado.PesoVenta;
                g.PrecioCompra = ganado.PrecioCompra;
                g.PrecioVenta = ganado.PrecioVenta;
                g.FechaRegistro = ganado.FechaRegistro;
                g.Estado = ganado.Estado;
                repoGanado.Update(ganados, true);
                return true;
            }
            catch (Exception e) { throw e; }
        }

        public bool Agregar(Ganado ganado)
        {
            try
            {
                repoGanado.Guardar(ganado);
                ganados = repoGanado.GetGanados();
                return true;
            }
            catch (Exception e) { throw e; }
        }

        public bool Eliminar(Ganado ganado)
        {
            {
                try
                {
                    ganados.Remove(ganado);
                    repoGanado.Update(ganados, false);
                    return true;
                }
                catch (Exception e) { throw e; }
            }
        }

        public List<Ganado> Listar() { return ganados; }
    }
}
