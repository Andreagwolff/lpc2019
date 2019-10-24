using System;

namespace ToDoList.Domain.Entities
{
    public class Person
    
    {
        public DateTime dataLeitura { get; set; }
        public int numeroLeitura { get; set; }
        public int kwGasto { get; set; }
        public double valorPagar { get; set; }
        public DateTime dataPagamento { get; set; }
        public double mediaConsumo { get; set; }
    }
}