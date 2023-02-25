using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteEstagio
{
    public class Distribuidora
    {
        public void Total(){
             decimal SP = 67836.43m;
            decimal RJ = 36678.66m;
            decimal MG = 29229.88m;
            decimal ES = 27165.48m;
            decimal outros = 19849.53m;

             decimal total = SP + RJ + MG + ES + outros;

            decimal percSp = (SP / total) * 100;
            decimal percRj = (RJ / total) * 100;
            decimal percMg = (MG / total) * 100;
            decimal percEs = (ES / total) * 100;
            decimal percOutros = (outros / total) * 100;


             Console.WriteLine($"Percentual de representação de SP: {percSp:F2}%");
            Console.WriteLine($"Percentual de representação de RJ: {percRj:F2}%");
            Console.WriteLine($"Percentual de representação de MG: {percMg:F2}%");
            Console.WriteLine($"Percentual de representação de ES: {percEs:F2}%");
            Console.WriteLine($"Percentual de representação de Outros: {percOutros:F2}%");

        }

        
    }
}