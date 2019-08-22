namespace livraria.obj
{
    public class usuarios
    {
        public usuarios(string nome, string local, int telefone, string senha)
        {
            this.nome = nome;
            this.local = local;
            this.telefone = telefone;
            this.senha = senha;

        }
        public string nome { get; set; }
        public string local { get; set; }
        public int telefone { get; set; }
        public string senha { get; set; }
    }
}