using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_BancoMorangao
{
    internal class Conta
    {
        public String TipoConta { get; set; }
        public String NumeroConta { get; set; }
        //gerar um numero aleatorio com random
        //chamar o numero da conta onde aprova a conta na classe funcionario
        public String Agencia { get; set; }
        public bool Aprovado { get; set; }


        //Método construtor que chamo dentro do cadastro do cliente
       
        public Conta()
        {

        }
        
        public Conta(string TipoConta)
        {

            if (TipoConta == "1")
            {
                this.TipoConta = "CONTA UNIVERSITÁRIA";
                this.Aprovado = false;
            }
            else if (TipoConta == "2")
            {
                this.TipoConta = "CONTA NORMAL";
                this.Aprovado = false;
            }
            else
            {
                this.TipoConta = "CONTA VIP";
                this.Aprovado = false;
            }

        }
              
    }
}
