using System;


namespace MeuApp
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
       var sala =new Sala(3);
       sala.SalaVendidaEvent += EmSalaCheia;
       sala.ReservaDeAssentos();
        sala.ReservaDeAssentos();
         sala.ReservaDeAssentos();
          sala.ReservaDeAssentos();
          sala.ReservaDeAssentos();
        }

        static void EmSalaCheia(object sender, EventArgs e){
            Console.WriteLine("Sala Lotada");
        }
   
   public class Sala
   {
       public Sala(int assentos){
           Assentos = assentos;
           SendoUsadas =0;
       }

       private int SendoUsadas =0;
       public int Assentos{get;set;}

       public void ReservaDeAssentos(){
           SendoUsadas++;
           if(SendoUsadas>=Assentos){
               AoSalaVendida(EventArgs.Empty);
           }else{
               Console.WriteLine("Assento reservado");
           }
       }
       public event EventHandler SalaVendidaEvent;
       protected virtual void AoSalaVendida(EventArgs e){
               EventHandler handler = SalaVendidaEvent;
               handler?.Invoke(this,e );
       }
       
   }


    }
    
}



