namespace livraria.obj
{
    public class revista
    {
        public revista(string colecao, string editora)
        {
            this.colecao = colecao;
            this.editora = editora;

        }
        public string colecao { get; set; }
        public string editora { get; set; }

        
    }
}