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


        List<Funcionario> CadFuncionario = new List<Funcionario>();

        public void AddListFuncionario(Funcionario funcionario)
        {
            CadFuncionario.Add(funcionario);
        }

        public Funcionario getFuncionario()
        {
            foreach (var funcionario in CadFuncionario)
            {
                return funcionario;
            }
            return null;
        }
    }


}
