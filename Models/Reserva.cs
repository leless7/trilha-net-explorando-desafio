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
            // IMPLEMENTADO!!
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // IMPLEMENTADO!!
                throw new Exception("A quantidade de Hóspedes ultrapassou o limite da capacidade de hóspedes da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // IMPLEMENTADO!!
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            
            // IMPLEMENTADO!!
            decimal valor = 0;
            // IMPLEMENTADO!!
            if (DiasReservados >= 10)
                valor = DiasReservados * Suite.ValorDiaria - (DiasReservados*Suite.ValorDiaria* 10 / 100);
            else
                valor = DiasReservados * Suite.ValorDiaria;

            return valor;
        }
    }
}