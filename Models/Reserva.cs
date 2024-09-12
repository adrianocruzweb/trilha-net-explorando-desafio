using System.Reflection.Metadata;

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
            Suite suite = new Suite();

            int quantidadeHospedes = ObterQuantidadeHospedes();

            bool capacidadeQuarto = true;

            capacidadeQuarto = suite.Capacidade < quantidadeHospedes;

            if (true)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("O quarto tem a capaciadade de: "+ suite.Capacidade +
                " não é possivel colocar "+ quantidadeHospedes);
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            List<Pessoa> hospedes = Hospedes;

            return hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = Suite.ValorDiaria;
            decimal diasReservados = DiasReservados;

            decimal valor = 0;
            valor = diasReservados*valorDiaria;

            valor = (diasReservados>=10?(valor-(valor*0.10M)):valor);

            return valor;
        }
    }
}