using System.Collections.Generic;

namespace contaLuz.Models
{
    public class ContaRepository
    {
       public static List<Conta> conta = new List<Conta>();
    
        public ContaRepository()
        {           
        }
        public void Create(Conta conta) => conta.Add(conta);
        public List<Conta> GetAll()
        {
            return conta;
        }
        
        public Conta GetById(int numeroLeitura)
        {
            return conta.Find(i=>i.numeroLeitura == numeroLeitura);
        }
        public void Delete(int numeroLeitura)
        {
            conta.Remove(GetById(numeroLeitura));
        }
        //maior
        public void List(){
            return Conta.OrderByDesending(x=>kwGasto).First();
            
        }
        //menor
        public void List(){
            return Conta.OrderDesending(x=>kwGasto).First();
            
        }

       
        
    }
}