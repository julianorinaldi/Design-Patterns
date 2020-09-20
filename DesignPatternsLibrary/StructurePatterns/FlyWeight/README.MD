[Retonar a raíz Design-Patterns](https://github.com/julianorinaldi/Design-Patterns)

# Design Pattern - FlyWeight

Permite a você colocar mais objetos na quantidade de RAM disponível ao compartilhar partes comuns de estado entre os múltiplos objetos ao invés de manter todos os dados em cada objeto.

Flyweight utiliza o princípio da imutabilidade, ou seja, a partir de uma instância no conceito Flyweight, todos os objetos que necessitam dela, usarão as mesma instância sem mudá-la. Como um ponteiro.

Pode ser usado em diferentes contextos, mas seu estado não pode ser modificado, deve inicializar seu estado apenas uma vez

Ele não deve se expor para qualquer setters ou campos públicos para outros objetos.

Em resumo, está dentro de outros objetos, porém outros objetos só podem lê-lo, não mudá-lo.

## Diagrama
![](../../Image/FlyWeightDiagrama.png)

Agora observando o diagrama, fica claro que tudo falado anterior, pode simplicar em um gerenciador de instância única.
Quase um gerenciador de cache.

## Diagrama
![](../../Image/FlyWeightExemplo.png)

O exemplo desenvolvido, foi retirado do site: https://refactoring.guru/pt-br/design-patterns/flyweight

Neste exemplo, mostra como o padrão Flyweight ajuda a reduzir o uso de memória na renderizando milhões de objetos do tipo árvore em uma tela.

### Explicando
- `Forest` representa o cliente, que agrega um array do objeto `Tree`
- `Tree` representa o contexto, que é o objeto que terá muitos e desejamos economizar memória, está ligado ao objeto que representa FlyWeight `TreeType`.
- `TreeType` representa o objeto FlyWeight, pois separa em uma estrutura que pode se repetir e reutilizar dentro de árvore `Tree`.
- `TreeFactory` representa nosso factory, o gerenciador de instâncias.

