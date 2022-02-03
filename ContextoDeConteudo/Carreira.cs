namespace ContextoDeConteudo{
    public class Carreira : Conteudo
    {
       public Carreira(){
           Items = new List<ItemDaCarreira>();
       }
       public IList<ItemDaCarreira> Items {get;set;}
       public int TotalDeCursos {
           get{
            return Items.Count;
       }
       }
    }
     


}