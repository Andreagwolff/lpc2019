namespace livraria.obj
{
    public class livros
    {
        public livros(string editora, string edicao, string isbn, string autor)
        {
            this.editora = editora;
            this.edicao = edicao;
            this.isbn = isbn;
            this.autor = autor;

        }
        public string editora { get; set; }
        public string edicao { get; set; }
        public string isbn { get; set; }
        public string autor { get; set; }

        public void mostrarDetalhes() => this.editora = this.edicao;
    }
}