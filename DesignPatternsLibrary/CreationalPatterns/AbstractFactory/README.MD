[Retonar a raíz Design-Patterns](https://github.com/julianorinaldi/Design-Patterns)

# Design Pattern - Abstract Factory

Fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.
Entenda família de objetos quando se trata de um objeto complexo.

## Explicação do cenário de código
Neste exemplo, tratamo de um Carro, que é composto de vários outros objetos, ou seja, objeto complexo.
No entanto um carro tem diferentes modelos, e com diferentes qualidades de peças que se tornam também objetos complexos, ex: Roda, Aparelho de Som, etc.
Com isso, podemos ter carro de corrida, carro popular, carro de luxo, e ainda abrir para opcionais.
Mas para exemplificar, ficamos com carro popular e carro de luxo.
O AbstractFactory através de sua classe abstrata, força a implemenação concreta de fábricas de objetos específicos que são responsáveis por montar uma família de objetos.
Neste caso a família seria um tipo de carro, como fábrica para montar um carro popular, ou de luxo.

## Vantagens:
- Elimina a necessidade de anexar classes específicas das aplicações
- Fornece um gancho para as subclasses. A criação de classes e subclasses se torna mais flexível.

## Desvantagens:
- Podemos ter que criar várias subclasses da classe Creator apenas para criar um ProdutoConcreto