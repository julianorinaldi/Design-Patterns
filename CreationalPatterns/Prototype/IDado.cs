using System;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    public interface IDado : ICloneable
    {
        // No .net existe a interface `ICloneable` que contém um método `object Clone();`
        // Que já representa a formulação do padrão.
    }
}