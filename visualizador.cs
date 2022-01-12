using System;
using System.Text;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Visualizador
    {
        public static void VisualizaTexto(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Visualização");
            Console.WriteLine("------------");
            Console.WriteLine("------------");
            Console.WriteLine("------------");
            SubstuiCaracter(texto);
            Console.ReadKey();
            Menu.ExibiMenu();


        }

        public static void SubstuiCaracter(string texto ){

            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var palavras=texto.Split(' ');
            
            for (var i=0;i< palavras.Length; i++){
                if(strong.IsMatch(palavras[i])){
            Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(
                       palavras[i].Substring(
                           palavras[i].IndexOf('>')+1,
                           (palavras[i].LastIndexOf('<')-1)-
                            palavras[i].IndexOf('>')
                        )
                       
                       );
                     Console.WriteLine(" ");
                }else {
                    Console.ForegroundColor =ConsoleColor.Black;
                    Console.Write(palavras[i]);
                    Console.Write(" ");
                }
            }

        }

    }
}