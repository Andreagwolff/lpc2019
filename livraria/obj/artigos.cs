namespace livraria.obj
{
    public class artigos
    {
        public artigos(string autor, string tituloArtigo)
        {
            this.autor = autor;
            this.tituloArtigo = tituloArtigo;

        }
        public string autor { get; set; }
        public string tituloArtigo { get; set; }

    }
}