namespace Entidad
{
    public class Ganado
    {
        public int IdGanado { get; set; }
        public string Raza { get; set; }
        public char Sexo { get; set; }
        public decimal Peso { get; set; }
        public int Meses { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public string FechaRegistro { get; set; }
        public bool Estado { get; set; }
        public decimal PesoVenta { get; set; }

        private decimal PrecioCompra_()
        {
            decimal ValorKgFlaco;
            if (Sexo == 'M')
            {
                ValorKgFlaco = 7000;
                PrecioCompra = Peso * ValorKgFlaco;
            }
            else
            {
                if (Sexo == 'H')
                {
                    ValorKgFlaco = 6000;
                    PrecioCompra = Peso * ValorKgFlaco;
                }
            }
            return PrecioCompra;
        }
        private decimal PrecioVenta_()
        {
            decimal ValorKgGordo;
            if (Sexo == 'M')
            {
                ValorKgGordo = 8000;
                Peso = Peso + (Meses * 20);
                PrecioVenta = (Peso * ValorKgGordo) - (Meses * 100000);
            }
            else
            {
                if (Sexo == 'H')
                {
                    ValorKgGordo = 7000;
                    Peso = Peso + (Meses * 20);
                    PrecioVenta = (Peso * ValorKgGordo) - (Meses * 100000);
                }
            }
            return PrecioVenta;
        }
        private decimal PesoVenta_()
        {
            if (Sexo == 'M')
            {
                PesoVenta = Peso + (Meses * 25);
            }
            else
            {
                if (Sexo == 'H')
                {
                    PesoVenta = Peso + (Meses * 20);
                }
            }

            return PesoVenta;
        }

        public override string ToString()
        {
            return $"{IdGanado};{Raza};{Sexo};{Peso};{Meses};{PesoVenta_()};{PrecioCompra_()};{PrecioVenta_()};{FechaRegistro};{Estado}";
        }
    }
}
