using System;

namespace DesignPatterns.CreationalPatterns.FacotyMethod
{
    public static class FabricarPersonagem
    {
        public static IPersonagem CriarPersonagem(PersonagemEnum personagemEnum)
        {
            switch (personagemEnum)
            {
                case PersonagemEnum.LiuKang:
                    return new LiuKang();
                case PersonagemEnum.Scorpion:
                    return new Scorpion();
                case PersonagemEnum.SubZero:
                    return new SubZero();
                default:
                    throw new Exception("Personagem não encontrado!");
            }
        }
    }
}
