using System;
namespace EditorHtml{

public static class Menu
    {
     
   
      public static void ExibiMenu(){
          Console.Clear();
          Console.BackgroundColor = ConsoleColor.Black;
          Console.ForegroundColor =ConsoleColor.Blue;
          DesenhaTela();
          EscreveOp();
          

          var op= short.Parse(Console.ReadLine());
          ManipulaOpcoes(op);
      }

      public static void DesenhaTela(){
           Console.Write("+");
         for(int i=0; i<=30; i++)
        Console.Write("-");

          Console.Write("+");
          Console.Write("\n");

          for(int linhas =0; linhas<=10; linhas++)
          {

               Console.Write("|");
               for(int i=0; i<=30; i++)
               Console.Write(" ");

               Console.Write("|");
               Console.Write("\n");
 
      }
       Console.Write("+");
         for(int i=0; i<=30; i++)
        Console.Write("-");

          Console.Write("+");
          Console.Write("\n");
      
      
      }
      
    public static void EscreveOp(){
        Console.SetCursorPosition(3,2);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3,3);
        Console.WriteLine("====================");
        Console.SetCursorPosition(3,4);
        Console.WriteLine("Selecione uma opção abaixo:");
        Console.SetCursorPosition(3,6);
        Console.WriteLine("1- Novo Arquivo");
        Console.SetCursorPosition(3,7);
        Console.WriteLine("2-Abrir");
        Console.SetCursorPosition(3,9);
        Console.WriteLine("0-Sair");
        Console.SetCursorPosition(3,10);
        Console.Write("Opção:");
    }
public static void ManipulaOpcoes(short op){
    switch (op){
        case 1: Editor.VisualizarTexto();break;
        case 2: Console.WriteLine("Visualizar");break;
        case 0: {
            Console.Clear();
            Environment.Exit(0);
            break;
    }
         default: ExibiMenu();break;
}
    }
}

}