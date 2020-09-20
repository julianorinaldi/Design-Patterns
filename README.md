# Design-Patterns

Este repositório foi usado para reciclar meus conhecimentos em Design Patterns.

Mas também está público para poder ajudar a qualquer pessoa que deseja aprender um pouco mais sobre Design Patterns.

## Como utilizar o repositório

Ele engloba todos os 23 Design Patterns criado pelo GOF - Gang dos 4 caboclos.

### Coboclos

-  Erich Gamma
-  John Vlissides
-  Richard Helm
-  Ralph Johnson

### Como eu estudei?

Para desenvolver os exemplos, foi estudado com mais de uma referência:
-  Curso Udemy, o que comprei achei ruim pra caramba e nem vou citar o nome dele. Tinha muitos cursos em muitas línguas, mas o que ecolhi em português, achei fraco.
-  Youtube, achei vários vídeos interessantes em diversas linguagens, mas nenhum bem estruturado que fosse do início ao fim com todos os patterns. Exemplos também muito repetidos.
-  Site: https://refactoring.guru/ este achei sensacional, com boa explicação, diagramas, exemplos, etc. Tudo que eu estudava, confirmava se no site estava de encontro. No site, só senti falta do `Interpreter`

Em praticamente todos os exemplos, criei com base no que entendi, então digo que não foram cópias dos exemplos, exceto um ou outro que não consegui pensar em um exemplo melhor e acabei utilizando o mesmo problema pela didática.

### Como você está estruturado os projetos

A solução está dividida em 2 projetos:

- Projeto de Console **DesignPatternsConsole**: Apenas para fazer as chamadas dos Patterns e mostrar em tela, praticamente ele representa o **Cliente** que consome o Pattern.
- Projeto **DesignPatternsLibrary**: Onde está a implementação de cada Pattern separado por pastas, ou melhor, namespaces.

Cada pasta que contém seu Design Pattern, tem um arquivo README.MD, que explica um pouco sobre ele. Aqui tentei colocar diversas formas de síntese, inclusive resumir minha compreensão.

### Quais são os Design Patterns?

Os Design Pattens estão divididos em 3 grupos com 23 design de soluções:
- Creational Pattern
  - [Abstract Factory](DesignPatternsLibrary/CreationalPatterns/AbstractFactory/)
  - [Builder](DesignPatternsLibrary/CreationalPatterns/Builder/)
  - [Factory Method](DesignPatternsLibrary/CreationalPatterns/FactoryMethod/)
  - [Prototype](DesignPatternsLibrary/CreationalPatterns/Prototype/)
  - [Singleton](DesignPatternsLibrary/CreationalPatterns/Singleton/)
- Structure Pattern]
  - [Adapter](DesignPatternsLibrary/StructurePatterns/Adapter/)
  - [Brigde](DesignPatternsLibrary/StructurePatterns/Brigde/)
  - [Composite](DesignPatternsLibrary/StructurePatterns/Composite/)
  - [Decorator](DesignPatternsLibrary/StructurePatterns/Decorator/)
  - [Facade](DesignPatternsLibrary/StructurePatterns/Facade/)
  - [Fly Weight](DesignPatternsLibrary/StructurePatterns/FlyWeight/)
  - [Proxy](DesignPatternsLibrary/StructurePatterns/Proxy/)
- Behavioral Pattern
  - [Chain Of Responsability](DesignPatternsLibrary/BehavioralPatterns/ChainOfResponsability/)
  - [Command](DesignPatternsLibrary/BehavioralPatterns/Command/)
  - [Interpreter](DesignPatternsLibrary/BehavioralPatterns/Interpreter/)
  - [Iterator](DesignPatternsLibrary/BehavioralPatterns/Iterator/)
  - [Mediator](DesignPatternsLibrary/BehavioralPatterns/Mediator/)
  - [Memento](DesignPatternsLibrary/BehavioralPatterns/Memento/)
  - [Observer](DesignPatternsLibrary/BehavioralPatterns/Observer/)
  - [State](DesignPatternsLibrary/BehavioralPatterns/State/)
  - [Strategy](DesignPatternsLibrary/BehavioralPatterns/Strategy/)
  - [Template Method](DesignPatternsLibrary/BehavioralPatterns/TemplateMethod/)
  - [Visitor](DesignPatternsLibrary/BehavioralPatterns/Visitor/)