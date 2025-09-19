# DIO - Trilha .NET - Explorando a linguagem C#
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de explorando a linguagem C#, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.

O seu programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.


![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

---

## Histórico de Alterações

- **Classes `Pessoa` e `Suite`**: As classes foram mantidas conforme o código inicial.
- **Classe `Reserva`**: A lógica do desafio foi implementada para:
    - **Validar a capacidade:** O método `CadastrarHospedes` agora verifica se o número de hóspedes não excede a capacidade da suíte. Se for o caso, uma `InvalidOperationException` é lançada.
    - **Obter hóspedes:** O método `ObterQuantidadeHospedes` foi implementado para retornar a contagem de hóspedes na lista.
    - **Calcular valor da diária:** O método `CalcularValorDiaria` agora calcula o valor total (`DiasReservados` x `ValorDiaria`) e aplica um desconto de 10% se o período da reserva for igual ou superior a 10 dias.

- **Classe `Program`**: O código principal foi completado para demonstrar o funcionamento do sistema, incluindo:
    - Criação de instâncias das classes `Pessoa`, `Suite` e `Reserva`.
    - Chamadas aos métodos de cálculo.
    - Impressão dos resultados no console.
    - Adição de um bloco `try-catch` para demonstrar o tratamento da exceção de capacidade.

---

## Solução
O código foi completado e agora o sistema é funcional, obedecendo a todas as regras e validações descritas acima. As implementações foram feitas nas seções comentadas com "TODO".