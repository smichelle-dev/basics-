using System.Collections.Generic;


namespace ContextoDeConteudo{
       public class Modulo
    {

        public Modulo()
        {
            Aula = new List<Aula>();
        }
        public int ordem { get; set; }
        public string Titulo { get; set; }

        public IList<Aula> Aula { get; set; }


    }
}
