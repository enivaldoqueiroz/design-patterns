# Design Patterns
## C# - Design Patterns

    Design Patterns ou padrões de projetos são soluções generalitas para problemas recorrentes 
    durante o desenvolvimento de um software.

    São modelos de soluções abstratas de alto nível para resolver problemas comuns 

    Cada padrão descreve um problema que ocorre com frequência e descreve o cerne da 
    solução de forma a poder REUSAR a solução muitas vezes em situações diferentes

    Obs.: Não é um framework, não é uma linguagem, não é um código pronto...

## Como e quando usar os padrões de projetos?
    
    Tenha bom senso
    Faça a sua parte bem feita(usando as boas práticas)
    Implemente a solução e veja se ela funciona(testes)
    Verificar se ela pode ser otimizada
    Idenfique e utilize o padrão de projeto que se ajusta ao seu caso
    O resultado final deve melhorar as deficiências verificadas no seu projeto

## Fundamentos

    Programar para um interface e não para uma implementação;
    Favorecer a comppsição sobre a herança
    Usar os princípios S.O.L.I.D
    Envitar o forte acoplamento entre as classes
    Menter uma alta coesão entre as classes

## Objetivo

    Apresetar e dicutir os principais padrões de projeto dentre 
    os 23 padrões apresentados pela Gang of four

    Fornecer pelo menos um exemplo de implementação funcional usando a linguagem C#

    Usar conceitos e recursos da programação orientada a objetos 
    como classes, interfaces, composição, herança, etc.

### Obs.: Os padrões de projetos não depedem de uma linguagem específica.

## Descrição dos padrões de projeto

### Factory
    
    Um Factory é um objeto usado para criar outros objetos.
    Usando o  padrão Factory criamos objetos sem expor a lógica de criação ao cliente.

    Catalogo GOF:
        - Factory Method
        - Abstract Factory

### Simple Factory (não esta entre os 5 padrões criacionais GOF)

    Um Simple Factory é um objeto que é usado para criar instâncias de um objeto para o cleinte
    Permite usar interfaces para criar objetos sem expor a lógica da criação do objeto ao cliente.

    Ex.:
    1 - O Cleinte precisa de um produto, mas ao invés de cria-lo diretamente usando o operador new ele 
    pede ao objeto Factory(Fabrica) um novo produto, fornecendo as informações sobre o tipo que necessita.

    2 - A fábrica instancia um novo produto concreto e em seguida retorna ao cliente o produto criado 
    (convertido para uma classe de produto abstrato)

    3 - O Cliente usa os produtos sem estar ciente de usar implementação concreta.