[Retonar a raíz Design-Patterns](https://github.com/julianorinaldi/Design-Patterns)

# Design Pattern - Bridge

Desacoplar uma abstração de sua implementação para que os dois possam variam independentemente.

O padrão Bridge tenta resolver esse problema ao trocar de herança para composição do objeto

Basicamente pode ser implementado da seguinte forma:
Através de uma classe concreta, encapsula como propriedade uma interface que representa a ponta (brige).

A interface conterá uma instância de um objeto, passado para a classe concreta no construtor (inversâo de dependência), ou no método que a classe concreta utiliza.

Nos métodos da classe concreta, se utiliza a interface para chamar o métodos de negócio.