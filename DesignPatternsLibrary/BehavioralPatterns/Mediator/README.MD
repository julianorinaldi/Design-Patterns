[Retonar a raíz Design-Patterns](https://github.com/julianorinaldi/Design-Patterns)

# Design Pattern - Mediator

Permite que você reduza as dependências caóticas entre objetos. O padrão restringe comunicações diretas entre objetos e os força a colaborar apenas através do objeto mediador.

Um elemento, acionado por um usuário, não se comunica com outros elementos diretamente, mesmo que pareça que ele deva fazer isso. Ao invés disso, o elemento apenas precisa fazer o mediador saber do evento, passando qualquer informação de contexto junto com a notificação.

Utilize o padrão Mediator quando é difícil mudar algumas das classes porque elas estão firmemente acopladas a várias outras classes.

O padrão lhe permite extrair todas as relações entre classes para uma classe separada, isolando quaisquer mudanças para um componente específico do resto dos componentes.

## Exemplo para compreensão
![](../../Image/MediatorEx1.png)

Perceba que todos os objetos estão falando com todos. Isso pode ser tornar um problema e se transformar em um forte acoplamento.
Neste exemplo é o caso onde podemos aplicar o padrão mediator.

![](../../Image/MediatorEx1.png)

Observe agora que tudo é gerenciado pelo um **Mediador**, ou seja, utilizando o Design Pattern Mediator, sendo assim, nosso mediator neste exemplo é o **Dialog**.

O exemplo desenvolvido é semelhante ao mostrado. Em uma pequena tela de login, onde compões todos os componentes utilizados pela tela, qualquer comportamento dos componentes para troca de mensagem será direcionado ao Mediador, que saberá o que fazer.

## Diagrama
![](../../Image/MediatorDiagrama.png)