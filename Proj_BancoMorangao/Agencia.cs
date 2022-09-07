using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_BancoMorangao
{
    internal class Agencia
    {
        public int NumeroAgencia { get; set; }
        public Endereco end;

        public Agencia()
        {

        }
        public void ImprimirAgencia()
        {
            Console.Write("Agencia 001");
            Console.Write("Endereço : Av. dos morangos gigantes\n N°500 \n Bairro: MorangoVilla\n Cidade: Morangolândia\n Estado: Fadalândia");
        }
        public void CadastrarAgencia()
        {
            end = new Endereco();
            Console.WriteLine("Informe o número da agência: ");
            NumeroAgencia = int.Parse(Console.ReadLine());
            end.CadastrarEndereco();
        }
        //public void ImprimirAgencia()
        //{
        //    Console.WriteLine($"Número da Agência: {NumeroAgencia}");
        //    end.ImprimirEndereco();
        //}


        //pensei em cadastrar o funcionario na agencia pq se nao for assim, quem cadastraria ele ?


        List<Cliente> CadCliente = new List<Cliente>();

        public void AddListCliente(Cliente cliente)
        {
            CadCliente.Add(cliente);
        }

        public void GetCliente()
        {

            if (CadCliente.Count == 0)
            {
                Console.WriteLine("Não existem clientes cadastrados!");
            }
            foreach (var cliente in CadCliente)
            {
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

        //Lista para cadastrar os funcionários
        public List<Funcionario> CadFuncionario = new List<Funcionario>();

        //Meotodo para adicionar funcionário cadastrado na lista
        public void AddListFuncionario(Funcionario funcionario)
        {
            CadFuncionario.Add(funcionario);
        }
        public void GetFuncionario()
        {
            if(CadFuncionario.Count == 0)
            {
                Console.WriteLine("Não existem funcionários cadastrados!");

            }
            foreach (var funcionario in CadFuncionario)
            {
                Console.WriteLine(funcionario + "\n");
            }
        }

        //Método para retornar objeto funcionario do tipo gerente p aprovar a conta
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

