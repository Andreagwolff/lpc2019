using System;
using System.Collections.Generic;

namespace livraria.obj
{
    public class reserva
    {
        public reserva(DateTime dataReserva, DateTime dataValidade)
        {
            this.dataReserva = dataReserva;
            this.dataValidade = dataValidade;

        }
        public DateTime dataReserva { get; set; }
        public DateTime dataValidade { get; set; }

        public List<reserva> reservas {get ; set;}
        public virtual material mostraDetalhes

    }
}