[Retonar a raíz Design-Patterns](https://github.com/julianorinaldi/Design-Patterns)

# Design Pattern - Factory Method
O Factory Method é um padrão criacional de projeto que fornece uma interface para criar objetos em uma superclasse.
Permite que as subclasses alterem o tipo de objetos que serão criados.

Basicamente utiliza-se a estratégia de separar as resposabilidades em interfaces, e utilizar uma classe fábrica com responsabilidade de criar objetos concretos do subtipo da interface.

A fábrica deve centralizar a criação de instâncias, pois ela saber como criar o objeto. No entanto, a forma de informar qual objeto deseja, depende da estratégia de chamada, neste exemplo, foi usado enumerador.
