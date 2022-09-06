using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_BancoMorangao
{
    internal class ContaPoupanca : Conta
    {
        double Saldo { get; set; }


        public ContaPoupanca()
        {

        }

        public void DepositarCP()
        {
            double valor;
            Console.WriteLine("Informe a quantia que deseja depositar em sua conta poupança");
            valor = double.Parse(Console.ReadLine());
            Saldo = Saldo + valor;
            Console.WriteLine($"SALDO CONTA POUPANÇA: {Saldo} ");
            //talvez fazer uma condição p se o valor do deposito for 0
        }

        public void SacarCP()
        {
            double valor; //valor do saque
            if (Saldo > 0)
                Console.WriteLine("Informe a quantidade que deseja sacar de sua conta poupança: ");
            valor = double.Parse(Console.ReadLine());
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

        public void ConsultarSaldoCP()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("CONSULTE AQUI O SALDO DISPONÍVEL EM SUA CONTA POUPANÇA");          
            Console.WriteLine($"SALDO DISPONÍVEL NA CONTA POUPANÇA: {Saldo}");
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
