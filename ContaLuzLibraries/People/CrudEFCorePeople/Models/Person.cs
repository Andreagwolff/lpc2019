using System;

namespace CrudEFCorePeople.Models
{
    public class Person
    {
        public Person (){}
    
        public Person(DateTime dataLeitura, int numeroLeitura, int kwGasto, double valorPagar, DateTime dataPagamento, double mediaConsumo)
        {
            this.dataLeitura = dataLeitura;
            this.numeroLeitura = numeroLeitura;
            this.kwGasto = kwGasto;
            this.valorPagar = valorPagar;
            this.dataPagamento = dataPagamento;
            this.mediaConsumo = mediaConsumo;

        }

        internal void Add(Person conta)
        {
            throw new NotImplementedException();
        }

        public DateTime dataLeitura { get; set; }
        public int numeroLeitura { get; set; }

        

        public int kwGasto { get; set; }

        internal object FindIndex(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public double valorPagar { get; set; }

        
        public DateTime dataPagamento { get; set; }
        public double mediaConsumo { get; set; }
    }
    }
