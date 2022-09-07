using System;
using System.Collections.Generic;

namespace Proj_BancoMorangao
{
    internal class Program
    {

        //Ao declarar um objeto na program, vc consegue ter acesso a ele sem precisar
        //declarar novamente
        static Agencia agencia = new Agencia(1);
        static List<Cliente> CadCliente = new List<Cliente>();

        static void Main(string[] args)
        {
            //int menu;
            //Funcionario funcionario = new Funcionario();
            //ContaCorrente cc = new ContaCorrente();
            //ContaPoupanca cp = new ContaPoupanca();

            MenuPrincipal();


        }
        static void MenuConta(Cliente cliente)
        {
            int opc;
            do
            {

                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("----------BEM VINDO AO MENU DE ACESSO A CONTA------------------------------");
                Console.WriteLine("0 - SAIR/ACESSAR O MENU DE CONTA");
                Console.WriteLine("1 - CONSULTAR SALDO DA CONTA");
                Console.WriteLine("2 - SACAR DA CONTA ");
                Console.WriteLine("3 - DEPOSITAR NA CONTA");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Digite a opção desejada: ");
                opc = int.Parse(Console.ReadLine());
                if (opc < 0 || opc > 3)
                    Console.WriteLine("OPÇÃO INVÁLIDA! Informe um número válido para acessar o menu:");
                else
                {
                    Console.Clear();
                    switch (opc)
                    {
                        case 0:
                            //chamar um menu..
                            Console.WriteLine("SAINDO...");
                            MenuCliente();
                            break;
                        case 1:
                            cliente.Conta.ConsultarSaldo();
                            if (cliente.Conta.Saldo == 0)
                            {
                                Console.WriteLine("SALDO ZERADO,DESEJA DEPOSITAR UMA QUANTIA?  (1 - SIM 2 - NÃO ) ");
                                int escolha = int.Parse(Console.ReadLine());
                                switch (escolha)
                                {
                                    case 1:
                                        //metodo de depositar
                                        Console.WriteLine("Informe a quantia que deseja depositar em sua conta: ");
                                        float qtd = float.Parse(Console.ReadLine());
                                        cliente.Conta.Depositar(qtd);
                                        //cliente.Conta.ConsultarSaldo();
                                        break;
                                    default:
                                        //voltar ao menu de conta
                                        MenuConta(cliente);
                                        break;
                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine("Informe a quantidade que deseja sacar de sua conta: ");
                            float valor = float.Parse(Console.ReadLine());
                            cliente.Conta.Sacar(valor);
                            //cliente.Conta.ConsultarSaldo();
                            MenuConta(cliente);
                            break;
                        case 3:
                            Console.WriteLine("Informe a quantia que deseja depositar em sua conta: ");
                            valor = float.Parse(Console.ReadLine());
                            cliente.Conta.Depositar(valor);
                            //cliente.Conta.ConsultarSaldo();
                            MenuConta(cliente);
                            break;
                    }
                }
            } while (opc != 0);


        }
        static void MenuCliente()
        {

            int opc = 0;
            do
            {

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
                            //cadastrou uma solicitação de abertura de conta
                            Cliente cliente = new Cliente();
                            cliente.SolicitarAberturaConta();
                            if (agencia.GetCliente(cliente.Cpf) == null)
                            {
                                agencia.AddListCliente(cliente);

                            }
                            else
                            {
                                Console.WriteLine("JÁ EXISTE UM CLIENTE CADASTRADO COM ESSE CPF");
                            }
                            break;
                        case 3:
                            //primeiro, verificar se o cliente foi aprovado para ter acesso ao 
                            //menu de conta
                            //verificar se o cliente existe?                            
                            Console.WriteLine("Informe o CPF do cliente que deseja acessar a  conta: ");
                            string cpfCliente = Console.ReadLine();
                            cliente = agencia.GetCliente(cpfCliente);
                            if (cliente == null)
                            {
                                Console.WriteLine("CLIENTE NAO ENCONTRADO");
                                Console.ReadKey();
                            }
                            else
                            {
                                //validar se a conta esta aprovada
                                //vali
                                if (cliente.Conta == null)
                                {
                                    Console.WriteLine("SUA CONTA AINDA NÃO ESTÁ APROVADA!");
                                    Console.ReadKey();

                                }
                                else
                                {

                                    if (cliente.Conta.Aprovado)
                                    {
                                        Console.WriteLine("ACESSO CONCEDIDO");
                                        MenuConta(cliente);

                                    }

                                }
                            }
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
                Console.WriteLine("2 - IMPRIMIR CADASTRO DE CLIENTE");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Digite a opção desejada: ");
                opc = int.Parse(Console.ReadLine());
                if (opc < 0 || opc > 2)
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

                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("---------------------MENU DO GERENTE ------------------------");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("1 - VOLTAR AO MENU PRINCIPAL");
                Console.WriteLine("2 - CADASTRAR FUNCIONÁRIOS ");
                Console.WriteLine("3 - IMPRIMIR CADASTRO COM O CARGOS");
                Console.WriteLine("4 - APROVAR ABERTURA DE CONTA");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Digite a opção desejada: ");
                opc = int.Parse(Console.ReadLine());
                if (opc < 0 || opc > 5)
                    Console.WriteLine("OPÇÃO INVÁLIDA! Informe um número válido para acessar o menu:");
                else
                {
                    Console.Clear();
                    switch (opc)
                    {
                        case 0:
                            Console.WriteLine("SAINDO...");
                            break;
                        case 1:
                            MenuPrincipal();
                            break;
                        case 2:
                            //cadastro de funcionário
                            Funcionario funcionario = new Funcionario();
                            if (agencia.GetFuncionario(funcionario.Cpf) == null)
                            {
                                agencia.AddListFuncionario(funcionario);

                            }
                            else
                            {
                                Console.WriteLine("JÁ EXISTE UM FUNCIONÁRIO CADASTRADO COM ESSE CPF");
                            }
                            break;
                        case 3:
                            //imprimir cadastro
                            agencia.GetFuncionario();
                            Console.ReadKey();
                            break;
                        case 4:
                            //aprovar a solicitação de abertura de conta
                            Console.WriteLine("Informe o CPF do funcionario que irá aprovar a solicitação de conta: ");
                            string cpfFuncionario = Console.ReadLine();
                            funcionario = agencia.GetFuncionario(cpfFuncionario);
                            Console.WriteLine("Informe o CPF do cliente que deseja aprovar a conta: ");
                            string cpfCliente = Console.ReadLine();
                            Cliente cliente = agencia.GetCliente(cpfCliente);
                            if (cliente == null)
                            {
                                Console.WriteLine("CADASTRO DO CLIENTE NÃO FOI ENCONTRADO");

                            }
                            else
                            {
                                if (funcionario == null)
                                {
                                    Console.WriteLine("NÃO FOI ENCONTRADO UM FUNCIONÁRIO CADASTRADO");
                                }
                                else
                                {
                                    Console.WriteLine("GERENTE, deseja aprovar a conta do cliente? 1- SIM 2- NÃO");
                                    int escolha = int.Parse(Console.ReadLine());
                                    cliente.Conta = new Conta(funcionario.AvaliarContaCliente(cliente.Renda, cliente.Perfil), agencia);

                                    if (escolha == 1)
                                    {

                                        cliente.Conta.Aprovado = funcionario.AprovarConta(true);

                                    }
                                    else
                                    {
                                        cliente.Conta.Aprovado = funcionario.AprovarConta(false);
                                    }

                                }

                            }
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

