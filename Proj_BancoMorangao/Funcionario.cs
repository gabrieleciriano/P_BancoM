using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_BancoMorangao
{
    internal class Funcionario : Pessoa
    {
        public bool Cargo { get; set; }

        public int agencia;


        //Lista criada para adicionar os clientes se forem aprovados p abrir a conta (?)
        List<Cliente> AprovaCliente = new List<Cliente>();

        public void AddListCliente(Cliente cliente)
        {
            AprovaCliente.Add(cliente); //metodo da classe lista que add clientes a lista de aprovação de conta
        }

        public Cliente getCliente()
        {
            foreach (var cliente in AprovaCliente)
            {
                return cliente;
            }
            return null;
        }

        //public void AprovarConta()
        //{
        //    foreach (var cliente in AprovaCliente)
        //    {
        //        if (cliente.Conta.Aprovado == false)
        //        {
        //            Console.WriteLine("Deseja aprovar a conta ? 1 - SIM 2 - NÃO");
        //            int aprova = int.Parse(Console.ReadLine());
        //            if (aprova == 1)
        //            {
        //                Console.WriteLine("CONTA APROVADA!");
        //                //gerar um numero aleatorio aq
        //                //instanciar uma nova conta e gerar o número
        //                cliente.Conta.Aprovado = true;
        //            }
        //            else
        //            {
        //                Console.WriteLine("CONTA REPROVADA");
        //            }
        //        }
        //    }

        //}

        //REALIZANDO O CADASTRO DO FUNCIONÁRIO DENTRO DE UM MÉTODO CONSTRUTOR
        public Funcionario()
        {
            Console.WriteLine("Efetuando o cadastro do funcionário...");
            Console.WriteLine("Informe seu nome: ");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Informe seu CPF: ");
            this.Cpf = Console.ReadLine();
            Console.WriteLine("informe seu RG: ");
            this.Rg = Console.ReadLine();
            int op;
            Console.WriteLine("Por fim, o mais importante, informe seu CARGO (1- FUNCIONÁRIO REGULAR 2 - GERENTE)");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine("FUNCIONÁRIO REGULAR ");
            }
            else
            {
                Console.WriteLine("GERENTE");
                this.Cargo = true;

            }
        }

        //IMPRIMINDO OS DADOS CADASTRADOS DO FUNCIONÁRIO
        public override string ToString()
        {
            return $"Nome: {Nome} \nCpf: {Cpf} \nRg: {Rg} \nCargo: {Cargo}".ToString();
        }

        //avaliar o tipo de conta do cliente
        //não sei se vou usar esse metodo
        //funcionario regular
        public int AvaliarContaCliente(float renda, bool perfil)
        {
            int tipoConta;

            if (perfil)
            {
                Console.WriteLine("Entendido, voce é estudante!");
                Console.WriteLine("Sua solicitação para abrir uma conta será avaliada !");
                tipoConta = 1;
            }
            else
            {
                Console.WriteLine("Entendido, você não é estudante!");
                Console.WriteLine("Sua solicitação para abrir uma conta será avaliada !");
                if (renda <= 5000)
                {

                    Console.WriteLine("Cliente, irá receber uma conta do tipo 2 - NORMAL!");
                    tipoConta = 2;

                }
                else
                {
                    Console.WriteLine("Cliente, irá receber uma conta do tipo 3 - VIP!");
                    tipoConta = 3;

                }
            }
            return tipoConta;
        }

        public bool Estudante(string ehUniversitario)
        {
            return ehUniversitario switch
            {
                "1" => true,
                _ => false

            };
        }


        //outro metodo p aprovar a conta que eu fiz mas n sei se esta certo
        //metodo ta dando errado...
        public bool AprovarConta(bool contaAprovada)
        {
            if(Cargo)
            {
                string situacaoContaAprovada = contaAprovada ? "Aprovado" : "Reprovado";               
                Console.WriteLine($" SITUAÇÃO DE CONTA: {situacaoContaAprovada}");
                return contaAprovada;

            }
            else
            {
                Console.WriteLine("SOMENTE O GERENTE PODE APROVAR UMA CONTA!");
                return false;
            }

        }       
    }
}




