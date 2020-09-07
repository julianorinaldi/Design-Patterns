using System;
using System.Security;
using DesignPatterns.CreationalPatterns.FacotyMethod;
using DesignPatterns.CreationalPatterns.Singleton;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton();
            FactoryMethod();


        }

        static void Singleton()
        {
            #region Singleton

            {
                Console.WriteLine("###Singleton###");
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

        static void FactoryMethod()
        {
            #region FactoryMethod
            Console.WriteLine("###FactoryMethod###");
            Console.WriteLine("Fabricando o primeiro personagem");
            IPersonagem personagem1 = FabricarPersonagem.CriarPersonagem(PersonagemEnum.LiuKang);
            Console.WriteLine($"Personagem fabricado: {personagem1.Nome}");

            Console.WriteLine("Fabricando o segundo personagem");
            IPersonagem personagem2 = FabricarPersonagem.CriarPersonagem(PersonagemEnum.Scorpion);
            Console.WriteLine($"Personagem fabricado: {personagem2.Nome}");

            Console.WriteLine("Fabricando o primeiro personagem");
            IPersonagem personagem3 = FabricarPersonagem.CriarPersonagem(PersonagemEnum.SubZero);
            Console.WriteLine($"Personagem fabricado: {personagem3.Nome}");
            #endregion
        }
    }
}
