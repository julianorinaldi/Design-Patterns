using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class CarroLuxoFactory : CarroFactory
    {
        public override TipoCarroEnum TipoCarro => TipoCarroEnum.Luxo;

        public override Roda MontarRoda()
        {
            return new RodaLigaLeve();
        }

        public override Som MontarSom()
        {
            return new BluetoothPlayer();
        }
    }
}