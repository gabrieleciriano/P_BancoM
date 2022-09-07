using System;
using System.Collections.Generic;
using System.IO;

namespace Proj_BancoMorangao
{
    internal class Cliente : Pessoa
    {

        public float Renda { get; set; }
        public bool Perfil { get; set; }
       

        public Conta Conta;
           

        //metodo construtor vazio
        public Cliente()
        {



        }
        

        
        public bool Estudante(string ehUniversitario)
        {
            return ehUniversitario switch
            {
                "1" => true,
                _ => false

            };
        }
        //criar no funcinario um metod aprova conta que vai ter um switch de aprovar conta c
        //um parametro de string
        //no program, console write line, gerente...
        //ler numa variavel e chamar o metodo de Aprovar conta
        //leitura do AprovarConta == true (Criar uma lista de contas, uma corrente e uma poupança)
        //add na lista de Contas
        //criar lkista de conta no cliente
        //se o func aprovu a conta, falar qual tipo de conta tem: conta corrente e cp
        //cada cont bool chequeEspecial



        public void SolicitarAberturaConta()
        {
            string TipoConta;
            end = new Endereco();
            //conta = new Conta(TipoConta);
            
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
            Console.WriteLine("Informe sua renda mensal: ");
            Renda = float.Parse(Console.ReadLine());
            //Conta = new Conta(AtribuirTipoConta());
            Console.WriteLine("Possível cliente, você é ESTUDANTE ? ( 1 - Sim 0 - Nao) ");
            Perfil = Estudante(Console.ReadLine());
            
        }
        public override string ToString()
        {
            return $"Nome: {Nome} \nData de Nascimento: {DataNascimento} \nEndereço: Rua ou Avenida: {end.Rua} \nNúmero: {end.Numero} \nBairro: {end.Bairro} \nCidade: {end.Cidade} \nEstado {end.Estado} \nTelefone: {Telefone} \nCpf: {Cpf} \nRg: {Rg}  \nRenda: {Renda} \nPerfil: {Perfil}".ToString();
        }

    }
}



