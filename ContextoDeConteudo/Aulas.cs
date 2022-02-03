using ContextoDeConteudo.Enums;


namespace ContextoDeConteudo{


public class Aula
    {
        public int ordem { get; set; }
        public string Titulo { get; set; }

        public double DuracaoEmMinutos{ get; set; }

         
        public EcontextoNivel Nivel { get; set; }
    }

}