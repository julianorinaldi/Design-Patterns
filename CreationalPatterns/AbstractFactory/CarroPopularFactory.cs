using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class CarroPopularFactory : CarroFactory
    {
        public override TipoCarroEnum TipoCarro => TipoCarroEnum.Popular;

        public override Roda MontarRoda()
        {
            return new RodaSimples();
        }

        public override Som MontarSom()
        {
            return new CDPlayer();
        }
    }
}