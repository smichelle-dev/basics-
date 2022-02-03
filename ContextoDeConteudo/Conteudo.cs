namespace ContextoDeConteudo
{

    public abstract class Conteudo
    {
        public Conteudo(){
        Id = Guid.NewGuid();
        }
    
    
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Url { get; set; }
}
}