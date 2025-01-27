using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    internal class Opcoes
    {
        public static int CriadorDeMenu(string titulo, string opcoes)
        {
            int _escolha;
            string[] _opcoes = opcoes.Split(",");
            
            Console.WriteLine($"====== {titulo} ======");
            for (int i = 0; i < _opcoes.Length; i++)
            {
                Console.WriteLine($"{1 + i} - {_opcoes[i]}");
            }
            Console.Write("R: ");
            _escolha = int.Parse(Console.ReadLine());
            Console.WriteLine($"====================");

            return _escolha;
        }
        public static void OpcoesDoMenu(int opcao)
        {

        }

    }
}
