using System;

namespace Modulo2Semana3 {
    class Program {
        static void Main(string[] args) {
            /* Exercício 01 - Defina o que é classe e o que é objeto 
             Uma classe é uma forma de definir um tipo de dado em uma linguagem orientada a objeto. 
            Ela é formada por dados e comportamentos. Para definir os dados são utilizados os atributos, 
            e para definir o comportamento são utilizados métodos. Um objeto é um elemento computacional 
            que representa, no domínio da solução, alguma entidade (abstrata ou concreta) do domínio de 
            interesse do problema sob análise. Objetos similares são agrupados em classes.
             */

            /* Exercício 4 - Defina o que é um atributo
             * Os Atributos em Programação Orientada a Objetos são os elementos que definem a estrutura 
             * de uma classe. Os atributos também são conhecidos como variáveis de classe, e podem ser 
             * divididos em dois tipos básicos: atributos de instância e de classe. Os valores dos 
             * atributos de instância determinam o estado de cada objeto. */

            /* Exercício 5 - Qual a diferença entre uma propriedade privada e uma pública?
             * Public: Atributos e métodos definidos como públicos poderão ser invocados, acessados e 
             * modificados através de qualquer lugar do projeto; Private: Atributos e métodos definidos 
             * como privados só poderão ser invocados, acessados e modificados somente por seu próprio 
             * objeto.*/

            /* Exercício 6 - Se você criar 5 objetos de uma classe, quantas vezes o construtor da classe 
             * será chamado? 
             Uma classe pode ter dois ou mais construtores, desde que todos tenham assinaturas diferentes.
             Neste caso, qual construtor será usado depende dos parâmetros usados na construção do objeto.
             */

            /* Exercício 7 - Por que você usa um construtor? e Exercício 8 - Quando um construtor de 
             * uma classe é chamado?
             * 
            Validação
            Se você precisa validar os dados e se alguma validação falhar o objeto não deve ser criado, e
            ntão um construtor ajuda bastante. Isto é especialmente verdade se para validar um membro um 
            outro já deve estar em estado válido. Fica complicado controlar isto se os membros podem ser 
            inicializados independentemente.

            Processamento
            O mesmo vale se algum processamento seja necessário com os parâmetros iniciais antes de criar 
            o objeto. Entre esses processamentos podemos incluir a aquisição de recursos externos, como 
            banco de dados, acesso ao sistema de arquivos, redes, etc., mas pode ser apenas cálculos 
            simples.

            Ordem de execução
            O construtor também permite determinar a ordem como cada membro é inicializado, seja 
            automaticamente ou manualmente. Sem um construtor o compilador ou o runtime da linguagem 
            determinará a ordem de inicialização dos membros, o que pode ser documentado ou não, até 
            porque pode não ser determinístico. Obviamente não é possível lidar com formas complexas 
            de inicialização de forma automática. Isto pode ser útil não só para determinar o fluxo 
            correto do processamento mas também validar corretamente.

            Concorrência
            A criação atômica é especialmente importante quando temos processamento concorrente. 
            Em hipótese alguma podemos disponibilizar o estado de um objeto que pode ser compartilhado 
            com outros caminhos de processamento sem que o objeto esteja inicializado por completo. 
            Entenda "por completo" como o mínimo para gerar um estado válido, não quer dizer que todos 
            os membros precisam estar inicializados, até porque alguns podem ser opcionais mesmo.
             */

            Pessoa pessoa = new Pessoa();
            pessoa.DataNascimento = new DateTime(1990, 1, 1);
            Console.WriteLine(pessoa.Idade());

            Calc calc = new Calc();
            Console.WriteLine(calc.Soma(1, 2, 5, 18));

            /* Exercício 10 - Dê um exemplo de abstração no mundo real.
             No mundo real, utilizamos abstrações o tempo todo. Tudo que não sabemos como funciona 
            por baixo dos panos pode ser considerado uma abstração. Para exemplificar melhor, vamos 
            tomar como exemplo a concessionária que realiza manutenções no seu carro. Você leva ele 
            até lá com um problema e ele volta funcionando.
             */
        }
    }
}