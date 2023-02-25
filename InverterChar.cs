using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteEstagio
{
    public class InverterChar
    {
         public static string Inverter(string str)
        {
            
            char[] chars = str.ToCharArray();

         
            int i = 0;
            int j = chars.Length - 1;

            while (i < j)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;

                i++;
                j--;
            }
             
            string invertida = new string(chars);

            return invertida;
        }
    }
}
