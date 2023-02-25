using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteEstagio
{
    public class Soma
    {
        public void somar()
        {
            int k = 0;
            int soma = 0;
            int indice = 13;

            while(k < indice)
            {
                k = k+1;
                soma = soma + k;
                
                Console.WriteLine(soma);//Percorrendo a soma

            }
            Console.WriteLine(soma); // resultado da soma
        }
       
    }
}