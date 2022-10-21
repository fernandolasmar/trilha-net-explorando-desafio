namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {            
            var totalDeHospedes = hospedes.Count;            
            
            if (Suite.Capacidade >= totalDeHospedes)
            {
                Hospedes = hospedes;
            }
            else
            {                
                Console.WriteLine($"Capacidade máxima da suíte: {Suite.Capacidade}, quantidade de hóspedes: {totalDeHospedes}, " +
                                    "você excedeu a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {            
            var totalDeHospedes = Hospedes.Count;
            return totalDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {            
            var totalDaDiaria = DiasReservados * Suite.ValorDiaria;
            decimal valor = totalDaDiaria;
            
            if (DiasReservados >= 10)
            {
                var descontoDiaria = (totalDaDiaria * 10) / 100;                
                valor = totalDaDiaria - descontoDiaria;
                Console.WriteLine($"Valor total: {totalDaDiaria}, você recebeu um desconto de {descontoDiaria}");
            }

            return valor;
        }
    }
}
