using System;

namespace Proj_BancoMorangao
{
    internal class ContaCorrente : Conta
    {
        double LimiteChequeEspecial { get; set; }
        double Saldo { get; set; }

        public ContaCorrente()
        {

        }
        public void DepositarCC()
        {
            double valor;
            Console.WriteLine("Informe a quantia que deseja depositar em sua conta corrente");
            valor = double.Parse(Console.ReadLine());
            ConsultarLimite();
            Saldo = Saldo + valor;
            Console.WriteLine($"SALDO: {Saldo} ");
            //talvez fazer uma condição p se o valor do deposito for 0
        }

        public void SacarCC()
        {
            double valor; //valor do saque
            if (Saldo > 0)
            Console.WriteLine("Informe a quantidade que deseja sacar de sua conta corrente: ");
            valor = double.Parse(Console.ReadLine());
            ContaCorrente cc = new ContaCorrente();
            Console.WriteLine("Abaixo será informado o valor do limite do cheque especial");
            cc.ConsultarLimite();
            Saldo = Saldo + LimiteChequeEspecial;               
            if ((Saldo == 0) || (Saldo < valor))
            {
                Console.WriteLine("Saque INDISPONÍVEL, saldo INSUFICIENTE !");
            }
            else
            {
                Saldo = Saldo - valor;
                Console.WriteLine($"QUANTIDADE SACADA: {Saldo} ");

            }               

        }

        //método para o cliente consultar quanto de limite de cheque ele possui
        public void ConsultarLimite()
        {
            Console.WriteLine("Informe o tipo de conta que recebeu: ");
            TipoConta = Console.ReadLine();
            if (TipoConta == "1")
            {
                LimiteChequeEspecial = 500;
                Console.WriteLine($"Você, que possui uma conta UNIVERSITÁRIA irá receber um valor de: {LimiteChequeEspecial} para o cheque especial");
               
            }
            else if (TipoConta == "2")
            {
                LimiteChequeEspecial = 2000;
                Console.WriteLine($"Você, que possui uma conta NORMAL,  irá receber um valor de: {LimiteChequeEspecial} para o cheque especial");

            }
            else if (TipoConta == "3")
            {
                LimiteChequeEspecial = 5000;
                Console.WriteLine($"Voce irá receber um valor de: {LimiteChequeEspecial} para o cheque especial");
            }               

        }

        public void ConsultarSaldoCC()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("CONSULTE AQUI O VALOR DISPONÍVEL EM SUA CONTA CORRENTE");
            Console.WriteLine($"LIMITE CHEQUE ESPECIAL DISPONÍVEL: {LimiteChequeEspecial}");
            Console.WriteLine($"SALDO DISPONÍVEL: {Saldo}");
            Console.WriteLine("----------------------------------------------------------");
        }

        //SEM CONSULTAR EXTRATO

    }
}
