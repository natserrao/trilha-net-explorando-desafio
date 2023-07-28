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
            if(hospedes.Count <= Suite.Capacidade){
                Hospedes = hospedes;
            }
            else{
                throw new Exception("O número de hóspedes é superior à capacidade da suíte");
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
            decimal valor = 0;
            decimal desconto = 0;

            if (DiasReservados >= 10)
            {
                desconto = (DiasReservados * Suite.ValorDiaria) * Convert.ToDecimal(0.1);
                valor = (DiasReservados * Suite.ValorDiaria) - desconto;
                return valor;
            }
            return DiasReservados * Suite.ValorDiaria;
        }
    }
}