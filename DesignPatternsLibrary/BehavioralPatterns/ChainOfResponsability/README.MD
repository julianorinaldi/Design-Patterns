[Retonar a raíz Design-Patterns](https://github.com/julianorinaldi/Design-Patterns)

# Design Pattern - Chain of Responsability

Usado para passar processar a ação, ou caso não consigo, passar a responsabilidade da execução para o próximo Handler

## Diagrama
![](../../Image/ChainOfResponsabilityDiagrama.png)

![](../../Image/ChainOfResponsabilityExemplo.png)

## Exemplo:
- `FinalizadorBagagem` representa nosso BaseHandler. Como tratamos como classe abstrata, ela representa o Handler + BaseHandler.
- `ConcreteHandler` representa nossas classes `TratamentoNacional` e `TratamentoInternacional`

O cenário do exemplo funciona o seguinte.

Supomos que temos uma esteira recebendo as bagagens dos proprietários.

Cada bagagem que chega é validado se é veio da origem nacional ou internacional.

Precisamos validar qual seu tratamento, se será enviado para o handler nacional, ou internacional.

Com isso, usamos o padrão ChainOfResponsability, que tenta tratar nacional, se não conseguir, passa responsabilidade para tratamento internacional.

Isso é uma cadeia sequencial de tratamento, se registrássemos mais, cada um iria tratar apenas o que é de sua responsabilidade.