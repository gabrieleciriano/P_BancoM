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
                Console.WriteLine("1 - VOLTAR AO MENU PRINCIPAL");
                Console.WriteLine("2 - SOLICITAR ABERTURA DE CONTA");
                Console.WriteLine("3 - ACESSAR CONTA");
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
                            MenuPrincipal();                           
                            break;
                        case 2:
                            cliente.SolicitarAberturaConta();
                            break;
                        case 3:
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
                Console.WriteLine("1 - VOLTAR AO MENU PRINCIPAL");
                Console.WriteLine("2 - CADASTRAR FUNCIONÁRIO");
                Console.WriteLine("3 - IMPRIMIR CADASTRO COM O CARGO");
                Console.WriteLine("4 - CADASTRAR CLIENTE");
                Console.WriteLine("5 - IMPRIMIR CADASTRO DE CLIENTE");
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
                            MenuPrincipal();                         
                            break;
                        case 2:
                            //cadastrando o funcionario
                            Funcionario funcionario = new Funcionario();
                            agencia.AddListFuncionario(funcionario);

                            break;
                        case 3:
                            //imprimir o cadastro                          
                            agencia.GetFuncionario();
                            Console.ReadKey();
                            break;
                        case 4:
                            //cadastrar cliente
                            Cliente cliente = new Cliente();
                            agencia.AddListCliente(cliente);
                            break;
                        case 5:
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
                Console.WriteLine("1 - VOLTAR AO MENU PRINCIPAL");
                Console.WriteLine("2 - CADASTRAR FUNCIONÁRIO");
                Console.WriteLine("3 - IMPRIMIR CADASTRO COM O CARGO");
                Console.WriteLine("4 - APROVAR ABERTURA DE CONTA");
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
                            MenuPrincipal();                                                  
                            break;
                        case 2:
                            Funcionario funcionario = new Funcionario();
                            agencia.AddListFuncionario(funcionario);
                            break;
                        case 3:
                            agencia.GetFuncionario();
                            Console.ReadKey();
                            break;
                        case 4:
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
          
        static void MenuFuncionario()
        {
            //Funcionario funcionario = new Funcionario();
            int cargo;

            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("-------------------MENU DO FUNCIONÁRIO-----------------------------------");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine("1 - PARA VOLTAR AO MENU PRINCIPAL");             
            Console.WriteLine("INFORME O CARGO QUE IRÁ RECEBER: (2 - FUNCIONÁRIO REGULAR OU 3 - GERENTE)");
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
                    MenuPrincipal();                   
                    break;
                case 2:
                    MenuFuncionarioRegular();
                    break;
                case 3:
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

