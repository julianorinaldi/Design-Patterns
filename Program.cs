using System;
using DesignPatterns.CreationalPatterns.Singleton;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton

            {
                Console.WriteLine("Iniciando objeto Singleton");
                Universo universo = Universo.GetInstance;
                Console.WriteLine("Adicionando uma galáxia");
                universo.AdicionaGalaxia(new Galaxia("Via Láctea"));
                Console.WriteLine("Listando as galáxias");
                string galaxiasOut = universo.MinhasGalaxias();
                Console.WriteLine(galaxiasOut);
            }

            {
                Console.WriteLine();
                Console.WriteLine("Iniciando novo objeto Singleton");
                Universo universo2 = Universo.GetInstance;
                Console.WriteLine("Adicionando uma galáxia");
                universo2.AdicionaGalaxia(new Galaxia("Horion"));
                Console.WriteLine("Listando as galáxias");
                string galaxiasOut2 = universo2.MinhasGalaxias();
                Console.WriteLine(galaxiasOut2);
            }

            Console.WriteLine("Perceba que os o segundo objeto ainda é o primeiro");

            #endregion



        }
    }
}
