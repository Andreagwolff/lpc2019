using System;

namespace livraria.obj
{
    public class emprestimo
    {
        public emprestimo(DateTime dataEmprestimo, DateTime dataRetorno, int atraso)
        {
            this.dataEmprestimo = dataEmprestimo;
            this.dataRetorno = dataRetorno;
            this.atraso = atraso;

        }
        public DateTime dataEmprestimo { get; set; }
        public DateTime dataRetorno { get; set; }
        public int atraso { get; set; }

    }
}