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


        //pensei em cadastrar o funcionario na agencia pq se nao for assim, quem cadastraria ele ?


        List<Cliente> CadCliente = new List<Cliente>();

        public void AddListCliente(Cliente cliente)
        {
            CadCliente.Add(cliente);
        }
        public void GetCliente()
        {
            foreach(var cliente in CadCliente)
            {
                Console.WriteLine(cliente+"\n"); 
            }           
        }

        //Lista para cadastrar os funcionários

        List<Funcionario> CadFuncionario = new List<Funcionario>();

        //Meotodo para adicionar funcionário cadastrado na lista
        public void AddListFuncionario(Funcionario funcionario)
        {
            CadFuncionario.Add(funcionario);
        }
        public void GetFuncionario()
        {
            foreach (var funcionario in CadFuncionario)
            {
                Console.WriteLine(funcionario + "\n");
            }
        }

        //Método para retornar objeto funcionario do tipo gerente p aprovar a conta
        public Funcionario getFuncionario()
        {
            foreach (var funcionario in CadFuncionario)
            {
                if(funcionario.Cargo == 2)
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
