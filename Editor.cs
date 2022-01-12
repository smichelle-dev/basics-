using System;
using System.Text;


namespace EditorHtml{
   public static class Editor{
       public static void VisualizarTexto(){
           Console.Clear();
           Console.BackgroundColor = ConsoleColor.White;
          Console.ForegroundColor =ConsoleColor.Black;
          Console.Clear();
          Console.WriteLine("Modo Editor");
           Console.WriteLine("------------");
           Inicia();
       }

       public static void Inicia(){
           var file =new StringBuilder();
           do{
               file.Append(Console.ReadLine());
               file.Append(Environment.NewLine);
           }while (Console.ReadKey().Key != ConsoleKey.Escape);

           Console.Write("--------------");
           Console.WriteLine("  Deseja salvar o arquivo?");
           Visualizador.VisualizaTexto(file.ToString());

           }
       }

   }
