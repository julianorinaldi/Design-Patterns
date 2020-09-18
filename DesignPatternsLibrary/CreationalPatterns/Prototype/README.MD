# Design Pattern - Prototype

Cria objetos por cópia de instância

Em resumo é realizado um clone de um objeto a partir de uma instância de outro.

Necessita tem uma classe base abstrata ou interface que implementa o método clone abastrato, onde cada uma filha que herdar, deverá implementar seu clone.

No caso do .NET, na linguagem C#, é de fácil implementação nativa, pelo método:

```
 instancia.MemberwiseClone() as IInterface
```

Incluse, existe a interface `ICloneable` que contém um método `object Clone();`