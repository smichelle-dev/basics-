using ContextoDeConteudo.Enums;

namespace ContextoDeConteudo
{
    public class Cursos : Conteudo
    {
        public Cursos()
        {
            Modulos = new List<Modulo>();
        }
        public string Tag { get; set; }
        public IList<Modulo> Modulos { get; set; }
        public double DuracaoEmMinutos{ get; set; }

        public EcontextoNivel Nivel { get; set; }

    }

    
    
}
