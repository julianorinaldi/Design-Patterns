[Retonar a raíz Design-Patterns](https://github.com/julianorinaldi/Design-Patterns)

# Design Pattern - Decorator

Adiciona responsabilidade adicionais a um objeto dinamicamente.

Basicamente intercepta a ação do objeto final, e injeta alguma modificação.
## Diagrama
![Decorator](../../Image/Decorator.png)

## Implementação
No exemplo construído, temos:
- `IDados` fazendo o papel da interface Componente.
- `ArquivoDeDados` fazendo o papel do Component Concreto, é o objeto "cru" sem os decorators.
- `DadosDecorator` faz o papel de Base Decorator, implementei ele como abstrato, pois não precisaremos em nenhum momento instancia-lo.
- As classes `CompactadorDeDados` e `EncriptadorDeDados` são nossos decorator que acaba utilizando para "decorar" ou modificar uma instância de `ArquivoDeDados`.

