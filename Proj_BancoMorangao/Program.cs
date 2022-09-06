using System;
using System.Collections.Generic;

namespace Proj_BancoMorangao
{
    internal class Program
    {

        //Ao declarar um objeto na program, vc consegue ter acesso a ele sem precisar
        //declarar novamente
        static Agencia agencia = new Agencia(1);

        static void Main(string[] args)
        {
            //int menu;
            //Funcionario funcionario = new Funcionario();
            //ContaCorrente cc = new ContaCorrente();
            //ContaPoupanca cp = new ContaPoupanca();


            MenuPrincipal();


        }
        static void MenuConta()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("----------BEM VINDO AO MENU DE ACESSO A CONTA------------------------------");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("1 - CONSULTAR SALDO DA CONTA CORRENTE");
                Console.WriteLine("2 - CONSULTAR SALDO DA CONTA POUPANÇA");
                Console.WriteLine("3 - SACAR DA CONTA CORRENTE");
                Console.WriteLine("4 - SACAR DA CONTA POUPANÇA");
                Console.WriteLine("5 - DEPOSITAR NA CONTA CORRENTE");
                Console.WriteLine("6 - DEPOSITAR NA CONTA POUPANÇA");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Digite a opção desejada: ");
                opc = int.Parse(Console.ReadLine());
                if (opc < 0 || opc > 6)
                    Console.WriteLine("OPÇÃO INVÁLIDA! Informe um número válido para acessar o menu:");
                else
                {
                    switch (opc)
                    {
                        case 0:
                            Console.WriteLine("SAINDO...");
                            break;
                        case 1:
                            //CHAMAR FUNCAO CADASTRAR FUNCIONARIO

                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                    }
                }
            } while (opc != 0);


        }

        static void MenuCliente()
        {
            Cliente cliente = new Cliente();
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("----------BEM VINDO AO MENU DO CLIENTE------------------------------");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("1 - SOLICITAR ABERTURA DE CONTA");
                //CHAMAR O MENU DE CONTA AQUI
                Console.WriteLine("2 - ACESSAR CONTA");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Digite a opção desejada: ");
                opc = int.Parse(Console.ReadLine());
                if (opc < 0 || opc > 3)
                    Console.WriteLine("OPÇÃO INVÁLIDA! Informe um número válido para acessar o menu: ");
                else
                {
                    switch (opc)
                    {
                        case 0:
                            Console.WriteLine("SAINDO ...");
                            break;
                        case 1:
                            cliente.SolicitarAberturaConta();
                            break;
                        case 2:
                            MenuConta();
                            //metodo de acessar conta
                            break;
                        default:
                            break;
                    }
                }
            } while (opc != 0);
            Console.Clear();
        }
        static void MenuFuncionarioRegular()
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("------------------MENU DO FUNCIONÁRIO REGULAR-----------------------");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("1 - CADASTRAR FUNCIONÁRIO");
                Console.WriteLine("2 - IMPRIMIR CADASTRO COM O CARGO");
                Console.WriteLine("3 - CADASTRAR CLIENTE");
                Console.WriteLine("4 - IMPRIMIR CADASTRO DE CLIENTE");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Digite a opção desejada: ");
                opc = int.Parse(Console.ReadLine());
                if (opc < 0 || opc > 5)
                    Console.WriteLine("OPÇÃO INVÁLIDA! Informe um número válido para acessar o menu:");
                else
                {
                    switch (opc)
                    {
                        case 0:
                            Console.WriteLine("SAINDO...");
                            break;
                        case 1:
                            //cadastrando o funcionario
                            Funcionario funcionario = new Funcionario();
                            agencia.AddListFuncionario(funcionario);
                            break;
                        case 2:
                            //imprimir o cadastro                          
                            agencia.GetFuncionario();
                            Console.ReadKey();
                            break;
                        case 3:
                            //cadastrar cliente
                            Cliente cliente = new Cliente();
                            agencia.AddListCliente(cliente);
                            break;
                        case 4:
                            //imprimindo o cadastro do cliente                            
                            agencia.GetCliente();
                            Console.ReadKey();

                            break;
                        default:
                            break;
                    }
                }
            } while (opc != 0);
        }
        static void MenuFuncionarioGerente()
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("---------------------MENU DO GERENTE ------------------------");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("1 - CADASTRAR FUNCIONÁRIO");
                Console.WriteLine("2 - IMPRIMIR CADASTRO COM O CARGO");
                Console.WriteLine("3 - APROVAR ABERTURA DE CONTA");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Digite a opção desejada: ");
                opc = int.Parse(Console.ReadLine());
                if (opc < 0 || opc > 5)
                    Console.WriteLine("OPÇÃO INVÁLIDA! Informe um número válido para acessar o menu:");
                else
                {
                    switch (opc)
                    {
                        case 0:
                            Console.WriteLine("SAINDO...");
                            break;
                        case 1:
                            Funcionario funcionario = new Funcionario();
                            agencia.AddListFuncionario(funcionario);                          
                            break;
                        case 2:
                            agencia.GetFuncionario();
                            Console.ReadKey();                                                   
                            break;
                        case 3:
                            //chama o get funcionario que esta no objeto agencia trazendo o obj funcionario
                            funcionario = agencia.getFuncionario();
                            //o objeto passa a existir e o metodo de aprovar conta pode ser executadao
                            funcionario.AprovarConta();
                            break;
                        default:
                            break;
                    }
                }
            } while (opc != 0);

        }
        //static void AprovarContaCliente()
        //{
        //    string aprovarConta;
        //    Cliente cliente = funcionario.getCliente();

        //    if (cliente != null)
        //    {
        //        //Mostra o cadastro dos dados do cliente
        //        Console.WriteLine(cliente);
        //        do
        //        {
        //            Console.WriteLine("Deseja aprovar a conta desse cliente ? 1 - APROVAR 2 - RECUSAR :");
        //            aprovarConta = Console.ReadLine();
        //        } while (aprovarConta != "1" && aprovarConta != "2");
        //        if (aprovarConta == "1")
        //        {
        //            Console.WriteLine("CONTA APROVADA COM SUCESSO !");
        //            funcionario.AprovarAberturaConta(cliente);


        //        }
        //        else
        //            Console.WriteLine("Sentimos muito em informar mas sua solicitação foi RECUSADA!");

        //    }
        //    else
        //        Console.WriteLine("Não há nenhum cadastro realizado para ser aprovado!");
        //}
        static void MenuFuncionario()
        {
            //Funcionario funcionario = new Funcionario();
            int cargo;

            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("-------------------MENU DO FUNCIONÁRIO-----------------------------------");
            Console.WriteLine("--------------DIGITE 0 QUANDO DESEJAR SAIR-------------------------------");
            Console.WriteLine("INFORME O CARGO QUE IRÁ RECEBER: (1 - FUNCIONÁRIO REGULAR OU 2 - GERENTE)");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Digite a opção: ");
            cargo = int.Parse(Console.ReadLine());

            // if (cargo < 0 || cargo > 2)
            //   Console.WriteLine("OPÇÃO INVÁLIDA! Informe um número válido para acessar o menu: ");
            //else
            //{
            switch (cargo)
            {
                case 0:
                    Console.WriteLine("SAINDO...");
                    break;
                case 1:
                    MenuFuncionarioRegular();
                    break;
                case 2:
                    MenuFuncionarioGerente();
                    break;
            }
            Console.Clear();
        }
        static void MenuPrincipal()
        {
            int opc;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(" BEM VINDO AO BANCO MORANGÃO, COMO PODEMOS TE AJUDAR ?");
            Console.WriteLine("---------------------MADE BY GABS---------------------");
            Console.WriteLine(" DIGITE (1 - PARA FUNCIONÁRIO OU 2 - PARA CLIENTE)");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Digite a opção desejada: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 0:
                        Console.WriteLine("SAINDO...");
                        break;
                    case 1:
                        MenuFuncionario();
                        break;
                    case 2:
                        MenuCliente();
                        break;
                    default:
                        break;
                }

            } while (opc != 1 || opc != 2);
        }
    }
}



















/*

List<Agencias> agencias = new List<Agencias>();
Agencias agencia = new Agencias();
agencia.NumeroAgencia = 001;
Endereco endereco = new Endereco();
agencia.endereco = endereco;
// agencia.endereco.Rua =


Funcionarios funcionario = new Funcionarios();
endereco = new Endereco();
Console.WriteLine("Efetuando o cadastro do funcionário");
Console.WriteLine("Informe seu nome: ");
funcionario.Nome = Console.ReadLine();
Console.WriteLine("Informe sua data de nascimento: ");
funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Informe os dados de seu endereço: ");
Console.WriteLine("Rua: ");
endereco.Rua = Console.ReadLine();
Console.WriteLine("Numero: ");
endereco.Numero = int.Parse(Console.ReadLine());
Console.WriteLine("Bairro: ");
endereco.Bairro = Console.ReadLine();
Console.WriteLine("Cidade: ");
endereco.Cidade = Console.ReadLine();
Console.WriteLine("Estado: ");
endereco.Estado = Console.ReadLine();
Console.WriteLine("Informe seu telefone com o DDD: ");
funcionario.Telefone = long.Parse(Console.ReadLine());
Console.WriteLine("Informe seu CPF: ");
funcionario.Cpf = Console.ReadLine();
Console.WriteLine("informe seu RG: ");
funcionario.Rg = Console.ReadLine();
*/



/*
DateTime DataNascimento = DateTime.Now;
 //1- cadatrar cliente
//chama o construtor
Cliente cliente = new Cliente();
Console.WriteLine(cliente.ToString());
//2-Cliente Solicitar abertura conta
cliente.SolicitarAberturaConta(); */











//3-Verificar tipo da conta funcionario.VerificarConta()
//4-Aprovar conta, conta.AbrirConta() tem q ser atributo da conta
//Aprovar conta funcionario.AprovarConta()
//5- Movimentar a conta
//6 - Cadastrar a conta criada
//menu
//conta.ConsultarSaldo(), conta.ConsultarExtrato(),conta.Sacar(), conta.Depositar(), conta.Transferir(), conta.EfetuarLogin()




