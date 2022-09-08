using System;
using System.Collections.Generic;

namespace Proj_BancoMorangao
{
    internal class Agencia
    {
        public int NumeroAgencia { get; set; }
        public Endereco end;

        public Agencia()
        {
            this.NumeroAgencia = 1;
            this.end = new Endereco();
            end.CadastrarEndereco();

        }
        public void ImprimirAgencia()
        {
            Console.Write("Agencia Morangão 001");
            Console.Write("Endereço : Rua Moranguinho \n N°25 \n Bairro: Vila do Morango \n Cidade: Morangolândia\n Estado: São Morango");
        }
        
            
        //Lista genérica para cadastrar clientes na agencia
        List<Cliente> CadCliente = new List<Cliente>();

        public void AddListCliente(Cliente cliente)
        {
            CadCliente.Add(cliente);
        }

        public void GetCliente()
        {

            if (CadCliente.Count == 0)
            {
                Console.WriteLine("\nNão existem clientes cadastrados!");
            }
            foreach (var cliente in CadCliente)
            {
                //Imprimindo os dados dos clientes cadastrados
                Console.WriteLine(cliente + "\n");

            }
        }
        public Cliente GetCliente(string cpf)
        {
            foreach (var cliente in CadCliente)
            {
                if (cliente.Cpf == cpf)
                {
                    return cliente;

                }
            }
            return null;
        }

        //Lista genérica para cadastrar os funcionários na agencia
        public List<Funcionario> CadFuncionario = new List<Funcionario>();

        //Metodo para adicionar funcionário cadastrado na lista
        public void AddListFuncionario(Funcionario funcionario)
        {
            CadFuncionario.Add(funcionario);
        }
        public void GetFuncionario()
        {
            if(CadFuncionario.Count == 0)
            {
                Console.WriteLine("\nNão existem funcionários cadastrados!");

            }
            foreach (var funcionario in CadFuncionario)
            {
                Console.WriteLine(funcionario + "\n");
            }
        }

        //Método para retornar um funcionário baseado em seu cpf p aprovar a conta
        public Funcionario GetFuncionario(string cpf)
        {
            foreach (var funcionario in CadFuncionario)
            {
                if (funcionario.Cpf == cpf)
                {
                    return funcionario;

                }
            }
            return null;
        }
        public Agencia(int numero)
        {
            this.NumeroAgencia = numero;

        }
    }

}

