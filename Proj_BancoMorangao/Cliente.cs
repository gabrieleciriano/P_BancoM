using System;
using System.IO;

namespace Proj_BancoMorangao
{
    internal class Cliente : Pessoa
    {

        public float Renda { get; set; }
        public string Perfil { get; set; }
        public bool Aprovado { get; set; }

        public Conta conta;


        public Cliente()
        {
            end = new Endereco();
            conta = new Conta();
            Console.WriteLine("Informe seu nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Informe sua data de nascimento: ");
            DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe os dados de seu endereço:");
            Console.WriteLine("Rua ou Avenida");
            end.Rua = Console.ReadLine();
            Console.WriteLine("Número: ");
            end.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Bairro: ");
            end.Bairro = Console.ReadLine();
            Console.WriteLine("Cidade: ");
            end.Cidade = Console.ReadLine();
            Console.WriteLine("Estado: ");
            end.Estado = Console.ReadLine();
            Console.WriteLine("Informe seu telefone com o DDD: ");
            Telefone = long.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu CPF: (XXX.XXX.XXX-XX) ");
            Cpf = Console.ReadLine();
            Console.WriteLine("informe seu RG: ");
            Rg = Console.ReadLine();

        }

        public override string ToString()
        {
            return $"Nome: {Nome} \nData de Nascimento: {DataNascimento} \nEndereço: Rua ou Avenida: {end.Rua} \nNúmero: {end.Numero} \nBairro: {end.Bairro} \nCidade: {end.Cidade} \nEstado {end.Estado} \nTelefone: {Telefone} \nCpf: {Cpf} \nRg: {Rg}".ToString();
        }

        public void ImprimirCadCliente()
        {
            Console.WriteLine($"Nome: {Nome} \nData de Nascimento: {DataNascimento} \nEndereço: Rua ou Avenida: {end.Rua} \nNúmero: {end.Numero} \nBairro: {end.Bairro} \nCidade: {end.Cidade} \nEstado {end.Estado} \nTelefone: {Telefone} \nCpf: {Cpf} \nRg: {Rg}");

        }


        public void setAprovado(bool valor)
        {
            Aprovado = valor;


        }

        public void SolicitarAberturaConta()
        {
            string TipoConta;

            Console.WriteLine("Informe sua renda mensal: ");
            Renda = float.Parse(Console.ReadLine());
            Console.WriteLine("Possível cliente, você é ESTUDANTE ? ( 1 - Sim 2 - Nao) ");
            TipoConta = Console.ReadLine();
            if (TipoConta == "1")
            {
                Console.WriteLine("Entendido, voce é estudante!");
                Console.WriteLine("Sua solicitação para abrir uma conta será avaliada !");
                conta = new Conta(TipoConta);

            }
            else
            {
                Console.WriteLine("Entendido, você não é estudante!");
                Console.WriteLine("Sua solicitação para abrir uma conta será avaliada !");
                if (Renda <= 5000)
                {

                    Console.WriteLine("Cliente irá receber uma conta do tipo 2 - NORMAL!");
                    TipoConta = "2";
                    conta = new Conta(TipoConta);
                }

                else
                {
                    Console.WriteLine("Cliente, você irá receber uma conta do tipo 3 - VIP!");
                    TipoConta = "3";
                    conta = new Conta(TipoConta);
                }
            }
        }

    }
}



