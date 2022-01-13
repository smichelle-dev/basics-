using System;


namespace Circulo
{

    public class AreaCirculo


    {
        public static void RecebeDados()
        {
            Console.WriteLine("Digite o valor:");
            double numero = double.Parse(Console.ReadLine());
            double n =3.14159;
            double total = (n * Math.Pow(numero,2));
            Console.WriteLine(total);

        }


    }

}