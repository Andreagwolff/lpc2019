namespace livraria.obj.Debug
{
    public class materiais
    {
        public materiais(int cod, string assunto, string titulo)
        {
            this.cod = cod;
            this.assunto = assunto;
            this.titulo = titulo;

        }
        public int cod { get; set; }
        public string assunto { get; set; }
        public string titulo { get; set; }
    }
}