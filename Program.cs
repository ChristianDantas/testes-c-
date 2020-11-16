using System;

namespace projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("digite o primeiro numero: ");

            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero: ");

            int n2 = int.Parse(Console.ReadLine());

           
            Console.WriteLine(" escolha a operação: [+]=soma / [-]=subtração / [x]=multiplicação / [/]=divisão / [p]=piracanjuba?");

           int escolha = char.Parse(Console.ReadLine());

            switch(escolha){ 
            case '+':

               int sim = n1 + n2;
                  Console.WriteLine("resultado= "+ sim);
                 break;

             case '-':

          int subtração = n1 - n2;
Console.WriteLine("Resultado= " + subtração);
            break;

             case 'x':
             case 'X':
            int multiplicação = n1 * n2;
 Console.WriteLine("Resultado= " +multiplicação);
            break;
             case '/':

            int divisão = n1 / n2;
 Console.WriteLine("Resultado= " +divisão);
            break;

            case 'p':
            case 'P':
           int piracanjuba = n1 + n1 * n2;
           Console.WriteLine("Resultado= " +piracanjuba);
            break;

            default:
            Console.WriteLine("sem resultado");
            break;

        }
         
        }
    }
}
