using System;

namespace Exerc5
{
    class Program
    {
        static void Main(string[] args)
        {

            int soma = 0;


            Console.WriteLine("Digite um valor numerico");
            string valor = Console.ReadLine();


            int[] numero = new int[valor.Length];
            int tamanho = numero.Length;

            for (int i = 0; i < tamanho; i++)
            {
                 
                String a = valor.Substring(i,1);
                int aux = Int32.Parse(a);
                numero[i] = aux;
                soma = aux+soma;
            }

            
          
            Console.WriteLine("Soma do numero" + soma);
        }
    }
}
