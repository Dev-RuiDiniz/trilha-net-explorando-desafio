// Classe Program.cs
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
// Para o teste, a reserva tem 12 dias (maior que 10) para aplicar o desconto.
Reserva reserva = new Reserva(diasReservados: 12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");

Console.WriteLine("---");

// Exemplo com exceção (para testar)
Console.WriteLine("--- Exemplo de exceção ---");
List<Pessoa> hospedesExcecao = new List<Pessoa>();
hospedesExcecao.Add(new Pessoa("João"));
hospedesExcecao.Add(new Pessoa("Maria"));
hospedesExcecao.Add(new Pessoa("Pedro")); // Terceiro hóspede para suíte de capacidade 2

try
{
    Reserva reservaExcecao = new Reserva(diasReservados: 5);
    reservaExcecao.CadastrarSuite(suite);
    reservaExcecao.CadastrarHospedes(hospedesExcecao);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}