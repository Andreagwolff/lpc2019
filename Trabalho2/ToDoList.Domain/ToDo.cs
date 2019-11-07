using System;

namespace ToDoList.Domain
{
    public class ToDo
    {
        public ToDo () {}
        public ToDo(int id, DateTime dataLeitura, int numeroLeitura, int kwGasto, double valorPagar, double mediaConsumo, DateTime dataPagamento)
        {
            this.id = id;
            this.dataLeitura = dataLeitura;
            this.numeroLeitura = numeroLeitura;
            this.kwGasto = kwGasto;
            this.valorPagar = valorPagar;
            this.mediaConsumo = mediaConsumo;
            this.dataPagamento = dataPagamento;

        }
        public int id { get; set; }
        public DateTime dataLeitura { get; set; }
        public int numeroLeitura { get; set; }
        public int kwGasto { get; set; }
        public double valorPagar { get; set; }
        public double mediaConsumo { get; set; }
        public DateTime dataPagamento { get; set; }
    }
}