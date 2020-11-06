using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CifradoPokemon
{
	public class Cifrado
	{

      
        string mostrar = "";
        string descifrado = "";
        static string alfabetoesp = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        static string alfabetoenp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char[] alfabetosparr =
        {
              alfabetoesp[0],
              alfabetoesp[1],
              alfabetoesp[2],
              alfabetoesp[3],
              alfabetoesp[4],
              alfabetoesp[5],
              alfabetoesp[6],
              alfabetoesp[7],
              alfabetoesp[8],
              alfabetoesp[9],
              alfabetoesp[10],
              alfabetoesp[11],
              alfabetoesp[12],
              alfabetoesp[13],
              alfabetoesp[14],
              alfabetoesp[15],
              alfabetoesp[16],
              alfabetoesp[17],
              alfabetoesp[18],
              alfabetoesp[19],
              alfabetoesp[20],
              alfabetoesp[21],
              alfabetoesp[22],
              alfabetoesp[23],
              alfabetoesp[24],
              alfabetoesp[25],
              alfabetoesp[26],

            };

        char[] alfabetoenarr =
                    {
              alfabetoenp[0],
              alfabetoenp[1],
              alfabetoenp[2],
              alfabetoenp[3],
              alfabetoenp[4],
              alfabetoenp[5],
              alfabetoenp[6],
              alfabetoenp[7],
              alfabetoenp[8],
              alfabetoenp[9],
              alfabetoenp[10],
              alfabetoenp[11],
              alfabetoenp[12],
              alfabetoenp[13],
              alfabetoenp[14],
              alfabetoenp[15],
              alfabetoenp[16],
              alfabetoenp[17],
              alfabetoenp[18],
              alfabetoenp[19],
              alfabetoenp[20],
              alfabetoenp[21],
              alfabetoenp[22],
              alfabetoenp[23],
              alfabetoenp[24],
              alfabetoenp[25],

            };


        public string encriptar(string palabra, string clave)
		{

            for (int i = 0, j = 0; i < palabra.Length; i++, j++)
            {

                if (palabra[i] <= alfabetosparr[0] && palabra[i] >= alfabetosparr[26])
                {
                    char palabracifrada = alfabetosparr[(((palabra[i] - alfabetosparr[0]) + (clave[j] - alfabetosparr[0])) % 26) + 1];
                    mostrar = mostrar + palabracifrada;
                }
                else if (palabra[i] >= alfabetosparr[0] && palabra[i] <= alfabetosparr[26])
                {
                    char palabracifrada = alfabetosparr[(((palabra[i] - alfabetosparr[0]) + (clave[j] - alfabetosparr[0])) % 26) + 1];
                    mostrar = mostrar + palabracifrada;

                }
                else
                {
                   return palabra;
                }

            }
            return mostrar;

        }

        public string desencriptar (string palabra, string clave)
		{

            for (int i = 0, j = 0; i < mostrar.Length; i++, j++)
            {
                if (mostrar[i] <= alfabetosparr[0] && mostrar[i] >= alfabetosparr[26])
                {
                    Console.WriteLine((mostrar[i] - alfabetosparr[0]) - (clave[j] - alfabetosparr[27]) % 27 + alfabetosparr[0]);
                }
                else if (mostrar[i] >= alfabetosparr[0] && mostrar[i] <= alfabetosparr[26])
                {
                    char palabracifrada = alfabetosparr[((mostrar[i] + (26 - clave[j])) % 27)];
                    descifrado = descifrado + palabracifrada;

                }
                else
                {
                    return palabra;
                }

            }
            return descifrado;
        }

        static string makeStringEqual(String str, String keyword)
        {
            StringBuilder sb = new StringBuilder("");
            if (str.Length > keyword.Length)
            {

                int j = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        sb.Append(' ');
                    }
                    else
                    {
                        sb.Append(keyword[j]);
                        j++;
                        j %= keyword.Length;
                    }
                }
            }
            return sb.ToString();
        }
    }
}
