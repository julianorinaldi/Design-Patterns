[Retonar a raíz Design-Patterns](https://github.com/julianorinaldi/Design-Patterns)

# Design Pattern - Adapter

Objetivo de adapção entre objetos incompatíveis.

A ideia é implementar uma classe adaptadora (praticamente um DE/PARA) com os métodos equivalente entre uma e outra classe que se deseja adaptar.

Como pressissa, está dividido em 4 objetos:
- Target - Define a interface específica do domínio que o cliente usa.
- Cliente - Colabora com objetos em conformidade com a interface Target.
- Adaptee - Define uma interface existente que precisa ser adaptada. É o objeto que será adaptado.
- Adaptador - Adapta a interface do Adptee à interface Target.

## Diagrama
![](../../Image/AdapterDiagrama.png)

O exemplo usado foi no seguinte cenário:

- Nossa aplicação gerava notas fiscais através de XML.
- Houve uma modificação em um sistema de terceiro que necessitava receber notas fiscais em formato JSON.
- Foi criado um adaptador de XML para JSON, neste caso usando herança.
- Também existe a possibilidade de fazer a adaptação através de interfaces.
 

