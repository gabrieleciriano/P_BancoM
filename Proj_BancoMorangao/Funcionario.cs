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

        public Agencia agencia;
        public bool EhGerente { get; set; }



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
                        cliente.conta.Aprovado = true;
                    }
                }
            }

        }


        public void AprovarAberturaConta(Cliente cliente)
        {
            cliente.setAprovado(true);


        }


        public Funcionario()
        {
            agencia = new Agencia();
            Console.WriteLine("Efetuando o cadastro do funcionário...");
            Console.WriteLine("Informe seu nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Informe seu CPF: ");
            Cpf = Console.ReadLine();
            Console.WriteLine("informe seu RG: ");
            Rg = Console.ReadLine();
            do
            {
                Console.WriteLine("Por fim, o mais importante, informe seu CARGO (1- FUNCIONÁRIO REGULAR 2 - GERENTE)");
                Cargo = int.Parse(Console.ReadLine());
                if (Cargo == 1)
                {
                    Console.WriteLine($"{Cargo} FUNCIONÁRIO REGULAR ");
                    this.Cargo = 1;
                }
                else if (Cargo == 2)
                {
                    Console.WriteLine($"{Cargo} GERENTE");
                    this.Cargo = 2;
                }
                else
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA! Infome 1 ou 2");
                }

            } while (Cargo != 1 || Cargo != 2);


        }
        public override string ToString()
        {
            return $"Nome: {Nome} \nCpf: {Cpf} \nRg: {Rg} \nCargo: {Cargo}".ToString();
        }

    }
}



