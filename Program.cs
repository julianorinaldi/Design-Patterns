﻿using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.FacotyMethod;
using DesignPatterns.CreationalPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.IO.Pipes;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Singleton();
            //FactoryMethod();
            AbstractFactory();
        }

        private static void Singleton()
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

            #endregion Singleton
        }

        private static void FactoryMethod()
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

            #endregion FactoryMethod
        }

        private static void AbstractFactory()
        {
            #region AbstractFactory

            List<Carro> carrosMontados = new List<Carro>();

            CarroFactory carroFactory = null;

            TipoCarroEnum[] carros = new TipoCarroEnum[] { TipoCarroEnum.Popular, TipoCarroEnum.Luxo };
            foreach (var tipoCarro in carros)
            {
                switch (tipoCarro)
                {
                    case TipoCarroEnum.Popular:
                        carroFactory = new CarroPopularFactory();
                        break;

                    case TipoCarroEnum.Luxo:
                        carroFactory = new CarroLuxoFactory();
                        break;

                    default:
                        throw new Exception($"TipoCarro: {tipoCarro} desconhecido!");
                }

                carrosMontados.Add(new Carro(carroFactory.TipoCarro)
                {
                    Roda = carroFactory.MontarRoda(),
                    Som = carroFactory.MontarSom()
                });
            }

            foreach (var carroMontado in carrosMontados)
            {
                Console.WriteLine($"Carro: {carroMontado.TipoCarro} \t Roda: {carroMontado.Roda.ToString()} \t Som: {carroMontado.Som.ToString()}");
            }

            #endregion AbstractFactory
        }
    }
}