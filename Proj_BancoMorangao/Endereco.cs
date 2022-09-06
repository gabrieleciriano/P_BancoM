using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_BancoMorangao
{
    internal class Endereco
    {
        public String Rua { get; set; }
        public int Numero { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }

        public Endereco()
        {


        }
        public void CadastrarEndereco()
        {
            Console.WriteLine("Informe os dados de seu endereço: ");
            Console.WriteLine("Rua: ");
            Rua = Console.ReadLine();
            Console.WriteLine("Numero: ");
            Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Bairro: ");
            Bairro = Console.ReadLine();
            Console.WriteLine("Cidade: ");
            Cidade = Console.ReadLine();
            Console.WriteLine("Estado: ");
            Estado = Console.ReadLine();
        }
        public void ImprimirEndereco()
        {
            Console.WriteLine($"Endereço: \nRua {Rua} \nNúmero: {Numero} \nBairro: {Bairro} \nCidade: {Cidade} \nEstado: {Estado}");
        }


    }

}
