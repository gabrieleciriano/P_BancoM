using System;

namespace Proj_BancoMorangao
{
    internal class Pessoa
    {
        public String Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Endereco end;
        public long Telefone { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }


        public Pessoa()
        {



        }

    }

}
