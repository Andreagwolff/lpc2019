using System;

namespace livraria.obj
{
    public class reservas
    {
        public reservas(DateTime dataReserva, DateTime dataValidade)
        {
            this.dataReserva = dataReserva;
            this.dataValidade = dataValidade;

        }
        public DateTime dataReserva { get; set; }
        public DateTime dataValidade { get; set; }

    }
}