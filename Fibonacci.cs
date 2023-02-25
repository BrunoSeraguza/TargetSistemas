using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



 public class Fibonacci
{
  
  public void Fibo()
  {
     Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            bool pertenceFibonacci = Verificar(numero);

            if (pertenceFibonacci)
            {
                Console.WriteLine($"O numero {numero} pertence a sequencia de Fibonacci");
            }
            else
            {
                Console.WriteLine($"O numero {numero} nao pertence a sequencia de Fibonacci");
            }

            Console.ReadKey();
        }

         static bool Verificar(int numero)
        {
             int a = 0;
            int b = 1;

            while (b < numero)
            {
                int c = a + b;
                a = b;
                b = c;

                if (b == numero)
                {
                    return true;
                }
            }

            return false;
        }

}
