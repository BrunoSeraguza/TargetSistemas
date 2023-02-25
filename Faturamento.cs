using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.IO;





namespace TesteEstagio
{
    public class Faturamento
    {
       public void Main()
        {
            // Lê os valores de faturamento do arquivo JSON
            string json = File.ReadAllText("faturamento.json");
            FaturamentoMensal faturamento = JsonConvert.DeserializeObject<FaturamentoMensal>(json);

            // Calcula o menor e o maior valor de faturamento
            int menorFaturamento = int.MaxValue;
            int maiorFaturamento = int.MinValue;
            int somaFaturamento = 0;
            int diasComFaturamentoAcimaDaMedia = 0;

            foreach (int valor in faturamento.Valores)
            {
                if (valor > 0)
                {
                    if (valor < menorFaturamento)
                    {
                        menorFaturamento = valor;
                    }

                    if (valor > maiorFaturamento)
                    {
                        maiorFaturamento = valor;
                    }

                    somaFaturamento += valor;
                }
            }

            // Calcula a média mensal de faturamento
            int mediaMensal = somaFaturamento / faturamento.DiasComFaturamento;

            // Conta quantos dias tiveram faturamento acima da média mensal
            foreach (int valor in faturamento.Valores)
            {
                if (valor > mediaMensal)
                {
                    diasComFaturamentoAcimaDaMedia++;
                }
            }

             
                
            // Imprime os resultados
            Console.WriteLine($"Menor faturamento: {menorFaturamento}");
            Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
            Console.WriteLine($"Dias com faturamento acima da média: {diasComFaturamentoAcimaDaMedia}");

            

        }
    }

    class FaturamentoMensal
    {
        public string Mes { get; set; }
        public int[] Valores { get; set; }

        public int DiasComFaturamento
        {
            get
            {
                int count = 0;

                foreach (int valor in Valores)
                {
                    if (valor > 0)
                    {
                        count++;
                    }
                }

                return count;
            }
        }

    }

}