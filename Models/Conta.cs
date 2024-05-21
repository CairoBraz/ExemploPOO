namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + saldo);
        }

        public abstract void Creditar(decimal valor);
    }
}
