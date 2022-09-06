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
        public String NumeroCartaoCredito { get; set; }
        public bool Aprovado { get; set; }

        public Conta()
        {



        }
        public Conta(string TipoConta)
        {
            if (TipoConta == "1")
            {
                this.TipoConta = "CONTA UNIVERSITÁRIA";
            }
            else if (TipoConta == "2")
            {
                this.TipoConta = "CONTA NORMAL";
            }
            else
                this.TipoConta = "CONTA VIP";

        }



        public void Depositar()
        {

        }
        public void ConsultarSaldo()
        {

        }

        public void ConsultarExtrato()
        {

        }
        public void Sacar()
        {

        }


        public void Transferir()
        {

        }

    }
}
