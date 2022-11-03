using System.IO;
using System;
using Entidad;

namespace Datos.Archivos
{
    public class ArcGanado
    {
        protected string ruta;

        public ArcGanado()
        {
            this.ruta = "ganado.txt";
        }

        public ArcGanado(string ruta)
        {
            this.ruta = ruta;
        }

        public bool Guardar(Ganado ganador)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(ganador.ToString());
                sw.Close();
                return true;
            }
            catch (Exception) { throw; }

        }
    }
}
