# Design Pattern - Proxy

Permite que você forneça um **substituto** ou um espaço reservado para outro objeto.

Um proxy controla o **acesso** ao objeto original, permitindo que você faça algo ou antes ou depois do pedido chegar ao objeto original.

## Diagrama
![](../../Image/ProxyDiagrama.png)

Pense que o padrão proxy é mesmo conceito de proxy web, que filtra o uso da internet.

Nosso exemplo, foi criado sobre este conceito de proxy filtrando uma url:
- `IConsomeInternet` representa nossa `ServiceInterface`
- `Internet` representa o serviço que possui a operação que será encapsulado pelo proxy. Coloquei como `internal` para que um cliente externo nem consiga acessar a classe.
- `Proxy`representa efetivamente nosso proxy, que encapsula o serviço `Internet`
- O cliente neste caso é feito pela chada do console.
- `GerenciadorSites` foi usado como facilitador para gerenciar os sites, apenas para separar as responsabilidades.