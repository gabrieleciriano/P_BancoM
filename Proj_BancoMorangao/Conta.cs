using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_BancoMorangao
{
    internal class Conta
    {
        public int TipoConta { get; set; }
        public String NumeroConta { get; set; }
        //gerar um numero aleatorio com random ?
        //chamar o numero da conta onde aprova a conta na classe funcionario
        public Agencia Agencia;
        public bool Aprovado { get; set; }
        public float Saldo { get; set; }
        float LimiteChequeEspecial { get; set; }


        //Método construtor que chamo dentro do cadastro do cliente

        public Conta(int tipoConta, Agencia agencia)
        {
            this.TipoConta = tipoConta;
            this.Agencia = agencia;
            NumeroConta = new Random().Next().ToString();


        }
        public Conta()
        {


        }

        public void ConsultarSaldo()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("CONSULTE AQUI O SALDO DISPONÍVEL EM SUA CONTA");           
            if (Saldo == 0)
            {
                Console.WriteLine("O SALDO ESTÁ ZERADO");

            }
            else
            {
                Console.WriteLine($"SALDO DISPONÍVEL: {Saldo}");
                Console.WriteLine("----------------------------------------------------------");
            }
        }
        public void Sacar(float valor)
        {
                      
            if ((Saldo <= 0) || (Saldo < valor))
            {
                Console.WriteLine("SAQUE INDISPONÍVEL, SALDO INSUFICIENTE");

            }
            else
            {
                Saldo = Saldo - valor;
                Console.WriteLine($"QUANTIDADE SACADA: {valor} ");
                Console.WriteLine($"SALDO ATUAL: {Saldo} ");

            }
        }



        public void Depositar(float valor)
        {           
            
            if (valor == 0)
            {
                Console.WriteLine("QUANTIA A SER DEPOSITADA É INSUFICIENTE!");
            }
            else
            {              
                Saldo = Saldo + valor;
                Console.WriteLine($"SALDO ATUAL: {Saldo} ");

            }

        }                  

    }
}
