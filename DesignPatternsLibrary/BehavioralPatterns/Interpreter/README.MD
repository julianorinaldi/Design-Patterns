[Retonar a raíz Design-Patterns](https://github.com/julianorinaldi/Design-Patterns)

# Design Pattern - Interpreter

Uma maneira de incluir elementos de linguagem em um programa.

Dada uma linguagem, defina uma representação para sua gramática junto com um intérprete que use a representação para interpretar sentenças na linguagem.


AbstractEpression:
- Declara uma interface para executar uma operação

TerminalExpression:
- Imprementa uma operação interpret associada a símbolos de terminal na gramática.
- Uma instância é necessária para cada símbolo de terminal na sentença.

Expressão:
- Uma dessas clases é requerida para cada regra R :: = R1R1 ... Rn na gramática.
- Mantém variáveis de instância do tipo AbstractExpression para cada um dos símbolos R1 a Rn.
- Implementa uma operação Interoret para símbolos não-terminais na gramática. Interpret geralmente chama-se recursivamente nas variáveis que representam R1 a Rn.

Contexto:
- Contém informações que são globais para o intérprete.

Cliente:
Constrói (ou recebe) uma árvore de sintaxe abstrata representando uma frase específica na linguagem que a gramática define. A árvore de sintaxe abstrata é montada a partir de instâncias das classes NonTerminalExpression e TerminalExpression.
Invoca a operação Interpret.