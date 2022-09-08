using System;
using System.Collections.Generic;

namespace Proj_BancoMorangao
{
    internal class Funcionario : Pessoa
    {
        public bool Cargo { get; set; }
        public Agencia Agencia;

        //public int agencia;


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

        //REALIZANDO O CADASTRO DO FUNCIONÁRIO DENTRO DE UM MÉTODO CONSTRUTOR
        public Funcionario()
        {
            //Console.WriteLine("Agencia onde irá trabalhar: ");
            //Agencia agencia = new Agencia();
            //Agencia.ImprimirAgencia();
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
        public int AvaliarContaCliente(float renda, bool perfil)
        {
            int tipoConta;

            if (perfil)
            {
                Console.WriteLine("\nEntendido, voce é ESTUDANTE!");
                Console.WriteLine("\nSua solicitação para abrir uma conta será avaliada !");
                Console.WriteLine("\nCliente, ao avaliarmos seu perfil, você poderá receber uma conta (1- UNIVERSITÁRIA)");
                tipoConta = 1;
            }
            else
            {
                Console.WriteLine("\nEntendido, você NÃO é ESTUDANTE!");
                Console.WriteLine("Sua solicitação para abrir uma conta será avaliada !");
                if (renda <= 3000)
                {
                    Console.WriteLine("\nCliente, ao avaliarmos seu perfil, você poderá receber uma conta (2 - NORMAL)");
                    tipoConta = 2;
                }
                else
                {
                    Console.WriteLine("Cliente, ao avaliarmos o seu perfil, você poderá receber uma conta (3 - VIP)");
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

        //Método booleano que se CARGO == true, o funcionário (gerente) pode aprovar conta
        //Se CARGO == false, esse funcionário não pode realizar essa operação
        public bool AprovarConta(bool contaAprovada)
        {
            if (Cargo)
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




