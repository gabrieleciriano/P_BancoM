using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_BancoMorangao
{
    internal class Funcionario : Pessoa
    {
        public int Cargo { get; set; }

        public int agencia;
       




        //Lista criada para adicionar os clientes se forem aprovados p abrir a conta
        List<Cliente> AprovaCliente = new List<Cliente>();

        public void AddListCliente(Cliente cliente)
        {
            AprovaCliente.Add(cliente); //metodo da classe lsta que add clientes a lista de aprovação de conta
        }

        public Cliente getCliente()
        {
            foreach (var cliente in AprovaCliente)
            {
                return cliente;
            }
            return null;
        }

        public void AprovarConta()
        {
            foreach (var cliente in AprovaCliente)
            {
                if (cliente.conta.Aprovado == false)
                {
                    Console.WriteLine("Deseja aprovar a conta ? 1 - SIM 2 - NÃO");
                    int aprova = int.Parse(Console.ReadLine());
                    if (aprova == 1)
                    {
                        Console.WriteLine("CONTA APROVADA!");
                        //gerar um numero aleatorio aq
                        //instanciar uma nova conta e gerar o número
                        cliente.conta.Aprovado = true;
                    }
                    else
                    {
                        Console.WriteLine("CONTA REPROVADA");
                    }
                }
            }

        }




        //public void AprovarAberturaConta(Cliente cliente)
        //{
        //    cliente.setAprovado(true);


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
                Console.WriteLine($"{op} FUNCIONÁRIO REGULAR ");
                this.Cargo = 1;
            }
            else
            {
                Console.WriteLine($"{op} GERENTE");
                this.Cargo = 2;
            }
        }

        //IMPRIMINDO OS DADOS CADASTRADOS DO FUNCIONÁRIO
        public override string ToString()
        {
            return $"Nome: {Nome} \nCpf: {Cpf} \nRg: {Rg} \nCargo: {Cargo}".ToString();
        }

    }
}



