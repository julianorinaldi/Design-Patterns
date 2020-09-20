using System;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsability
{
    public class ReceitaFederal
    {
        public static bool AprovaEntradaBagagem(Bagagem bagagem)
        {
            // Faz as validações e Investigação da Bagagem e proprietário
            Random randomBool = new Random();
            var random = randomBool.Next(0, 10);
            if (random >= 5)
                return true;

            return false;
        }
    }
}