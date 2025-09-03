using System.Linq.Expressions;

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
                                          
                Hospedes = hospedes;
            
            if (Hospedes.Count != Suite.Capacidade)
            {
                throw new Exception("Ocorreu uma exeção, a quantidade de hóspedes é maior que a capacidade da suíte");
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


            if (DiasReservados >= 10)
            {
                valor = DiasReservados * (Suite.ValorDiaria - (Suite.ValorDiaria * 0.1M));
            }
            else
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }

            return valor;
        }
    }
}