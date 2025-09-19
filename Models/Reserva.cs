namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new InvalidOperationException("A capacidade da suíte é menor que o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valorTotal *= 0.90m;
            }

            return valorTotal;
        }
    }
}
