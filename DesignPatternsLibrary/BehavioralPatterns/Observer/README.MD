[Retonar a raíz Design-Patterns](https://github.com/julianorinaldi/Design-Patterns)

# Design Pattern - Observer

Permite que você defina um mecanismo de assinatura para notificar múltiplos objetos sobre quaisquer eventos que aconteçam com o objeto que eles estão observando.

Talvez um dos patterns mais fáceis e mais usados no dia a dia.

Sempre que um evento importante acontece com a publicadora `Publisher`, ele passa para seus assinantes `Subscriber` e chama um método específico de notificação em seus objetos.

Aplicações reais podem ter dúzias de diferentes classes assinantes que estão interessadas em acompanhar eventos da mesma classe publicadora. Você não iria querer acoplar a publicadora a todas essas classes. Além disso, você pode nem estar ciente de algumas delas de antemão se a sua classe publicadora deve ser usada por outras pessoas.

É por isso que é crucial que todos os assinantes implementem a mesma interface e que a publicadora comunique-se com eles apenas através daquela interface. Essa interface deve declarar o método de notificação junto com um conjunto de parâmetros que a publicadora pode usar para passar alguns dados contextuais junto com a notificação.

## Diagrama
![](../../Image/ObserverDiagrama.png)

No exemplo foi criado uma simulação de um agente onde contém o valor do dinheiro, e a cada um tempo, ele envia este valor para as pessoas que estão inscritas para receberem.

- `ISubscriberMoney` faz o papel da interface `Subscriber`
- `PublisherMoneyTime` faz o papel do `Publisher`
- `MoneyObserver` faz o papel da classe concreta que implementa o Subscriber.

No exemplo, foi mostrado de forma simples a inscrição de `MoneyObserver` no `PublisherMoneyTime`, enviado notificação para os inscritos, e depois removido um inscrito, e enviado novamente notificação.