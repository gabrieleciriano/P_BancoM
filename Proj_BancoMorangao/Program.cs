using System;
using System.Collections.Generic;

namespace Proj_BancoMorangao
{
    internal class Program
    {

        //Ao declarar um objeto na program, vc consegue ter acesso a ele sem precisar
        //declarar novamente
        static Funcionario funcionario = new Funcionario();
        static Agencia agencia = new Agencia();


        static void Main(string[] args)
        {
            //int menu;


            int menu = MenuPrincipal();

            switch (menu)
            {
                case 1:
                    MenuFuncionario();
                    break;
                case 2:
                    MenuCliente();
                    break;
                default:
                    break;
            }



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
                Console.WriteLine("1 - CONSULTAR SALDO"); // pgt de qual conta, corrente ou poupança
                Console.WriteLine("2 - CONSULTAR EXTRATO"); // pgt de qual conta, corrente ou poupança
                Console.WriteLine("3 - SACAR"); // pgt de qual conta, corrente ou poupança
                Console.WriteLine("4 - DEPOSITAR"); // pgt de qual conta, corrente ou poupança
                Console.WriteLine("5 - TRANSFERIR"); // pgt de qual conta, corrente ou poupança
                Console.WriteLine("5 - REALIZAR PAGAMENTOS ");
                Console.WriteLine("6 - REALIZAR EMPRÉSTIMOS ");
                //TALVEZ AQ DENTRO TER A OPÇÃO DE CONSULTAR EMPRESTIMO
                Console.WriteLine("5 - SOLICITAR EMPRÉSTIMO ");
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
            Cliente cliente;
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("----------BEM VINDO AO MENU DO CLIENTE------------------------------");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("1 - CADASTRAR CLIENTE");
                Console.WriteLine("2 - IMPRIMIR CADASTRO DO CLIENTE");
                Console.WriteLine("3 - SOLICITAR ABERTURA DE CONTA");
                Console.WriteLine("4 - ACESSAR CONTA, CASO JÁ SEJA UM CLIENTE");
                //talvez dentro do acessar conta colocar o solc emprestimo, desbloquear cartao
                //CHAMAR MENU DE CONTA - CC - POUPANÇA - SALDO - CARTAO - EMPRRSTIMO
                Console.WriteLine("5 - SOLICITAR EMPRÉSTIMO ");
                //nao eh possivel solicitar um emprestimo sem ter uma conta
                Console.WriteLine("6 - CARTÃO DE CRÉDITO ");
                //desbloquear, limite, fatura, parcelar, pagar fatura
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Digite a opção desejada: ");
                opc = int.Parse(Console.ReadLine());
                if (opc < 0 || opc > 6)
                    Console.WriteLine("OPÇÃO INVÁLIDA! Informe um número válido para acessar o menu: ");
                else
                {
                    switch (opc)
                    {
                        case 0:
                            Console.WriteLine("SAINDO ...");
                            break;
                        case 1:
                            Console.Clear();
                            cliente = new Cliente();   //deu certo
                            funcionario.AddListCliente(cliente); //add na lista                           
                            break;
                        case 2:
                            Console.Clear();
                            cliente = new Cliente();
                            Console.WriteLine(funcionario.getCliente());  //imprimir tudo o que está na minha lista de clientes                          
                            Console.ReadKey();

                            break;
                        case 3:
                            Console.Clear();
                            break;
                        case 4:
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
                            Console.Clear();
                            funcionario = new Funcionario();
                            agencia.AddListFuncionario(funcionario);
                            break;
                        case 2:
                            Console.Clear();
                            funcionario = new Funcionario();
                            Console.WriteLine(agencia.getFuncionario());
                            Console.ReadKey();
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
                Console.WriteLine("3 - AUTORIZAR ABERTURA DE CONTA");
                Console.WriteLine("4 - AUTORIZAR EMPRÉSTIMO ");
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
                            Console.Clear();
                            funcionario = new Funcionario();
                            agencia.AddListFuncionario(funcionario);
                            break;
                        case 2:
                            Console.Clear();
                            funcionario = new Funcionario();
                            Console.WriteLine(agencia.getFuncionario());
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            AprovarContaCliente();
                            break;
                        case 4:
                            Console.Clear();
                            break;
                        case 5:
                            Console.Clear();
                            break;
                    }
                }
            } while (opc != 0);


        }
        static void AprovarContaCliente()
        {
            string aprovarConta;
            Cliente cliente = funcionario.getCliente();

            if (cliente != null)
            {
                //Mostra o cadastro dos dados do cliente
                Console.WriteLine(cliente);
                do
                {
                    Console.WriteLine("Deseja aprovar a conta desse cliente ? 1 - APROVAR 2 - RECUSAR :");
                    aprovarConta = Console.ReadLine();
                } while (aprovarConta != "1" && aprovarConta != "2");
                if (aprovarConta == "1")
                {
                    Console.WriteLine("CONTA APROVADA COM SUCESSO !");
                    funcionario.AprovarAberturaConta(cliente);


                }
                else
                    Console.WriteLine("Sentimos muito em informar mas sua solicitação foi RECUSADA!");

            }
            else
                Console.WriteLine("Não há nenhum cadastro realizado para ser aprovado!");
        }
        static void MenuFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            int cargo;

            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("-------------------MENU DO FUNCIONÁRIO-----------------------------------");
            Console.WriteLine("--------------DIGITE 0 QUANDO DESEJAR SAIR-------------------------------");
            Console.WriteLine("INFORME O CARGO QUE IRÁ RECEBER: (1 - FUNCIONÁRIO REGULAR OU 2 - GERENTE)");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Digite a opção: ");
            cargo = int.Parse(Console.ReadLine());
            if (cargo < 0 || cargo > 2)
                Console.WriteLine("OPÇÃO INVÁLIDA! Informe um número válido para acessar o menu: ");
            else
            {
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
            }
            Console.Clear();
        }

        static int MenuPrincipal()
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
            } while (opc < 0 || opc > 2);
            return opc;
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




