# Design Pattern - Singleton

O Singleton é um padrão de projeto criacional que permite a você garantir que uma classe tenha apenas uma instância, enquanto provê um ponto de acesso global para essa instância.

Como exemplo, usamos uma classe Universo, que fica fácil entender que apenas existe um universo (se não considerar os paralelos rsrsrs).
Então toda ver que precisar de um Universo, chama-se o método GetInstance, pois o construtor da classe é privada e não tem como acessar externamente.

## Informações relevantes

 - Código exemplo:
```csharp
private static volatile Universo instance;
```

 - **volatine**: A palavra-chave volatile indica que um campo pode ser modificado por vários threads que estão em execução ao mesmo tempo. O compilador, o sistema do runtime e até mesmo o hardware podem reorganizar as leituras e gravações para locais de memória por motivos de desempenho. Os campos que são declarados volatile não estão sujeitos a essas otimizações. A adição do modificador volatile garante que todos os threads observarão gravações voláteis executadas por qualquer outro thread na ordem em que elas foram executadas. Não há nenhuma garantia de uma única ordenação total de gravações voláteis como visto em todos os threads de execução.
