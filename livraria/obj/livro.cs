using livraria.obj.Debug;

namespace livraria.obj
{
    public class livro : material
    {
        public livro(string editora, string edicao, string isbn, string autor): base (cod,assunto)
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

        
    }
}