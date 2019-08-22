namespace livraria.obj
{
    public class revistas
    {
        public revistas(string colecao, string editora)
        {
            this.colecao = colecao;
            this.editora = editora;

        }
        public string colecao { get; set; }
        public string editora { get; set; }

        public void mostrarDetalhes() => this.colecao = this.editora;
    }
}