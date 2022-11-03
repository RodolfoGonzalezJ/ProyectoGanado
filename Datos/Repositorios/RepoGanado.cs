using System.Collections.Generic;
using System.IO;
using System;
using Entidad;
using Datos.Archivos;

namespace Datos.Repositorios
{
    public class RepoGanado : ArcGanado
    {
        public RepoGanado() : base()
        {
        }

        public RepoGanado(string ruta) : base(ruta)
        {
        }

        public List<Ganado> GetGanados()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Ganado> ganados = new List<Ganado>();
                while (!sr.EndOfStream)
                {
                    ganados.Add(Mappear(sr.ReadLine()));
                }
                sr.Close();
                return ganados;
            }
            catch (Exception e) { throw e; }
        }

        public Ganado Mappear(string cadena)
        {
            try
            {
                Ganado ganado = new Ganado();
                ganado.IdGanado = int.Parse(cadena.Split(';')[0]);
                ganado.Raza = cadena.Split(';')[1];
                ganado.Sexo = char.Parse(cadena.Split(';')[2]);
                ganado.Peso = decimal.Parse(cadena.Split(';')[3]);
                ganado.Meses = int.Parse(cadena.Split(';')[4]);
                ganado.PesoVenta = decimal.Parse(cadena.Split(';')[5]);
                ganado.PrecioCompra = decimal.Parse(cadena.Split(';')[6]);
                ganado.PrecioVenta = decimal.Parse(cadena.Split(';')[7]);
                ganado.FechaRegistro = cadena.Split(';')[8];
                ganado.Estado = bool.Parse(cadena.Split(';')[9]);
                return ganado;
            }
            catch (Exception e) { throw e; }
        }

        public bool Update(List<Ganado> ganados, bool modo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, modo);
                foreach (var item in ganados) { sw.WriteLine(item.ToString()); }
                sw.Close();
                return true;
            }
            catch (Exception e) { throw e; }

        }
    }
}
