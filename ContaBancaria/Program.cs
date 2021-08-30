using ContaBancaria.Classes;
using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta minhaConta = new Conta(Enum.TipoConta.PessoaFisica,"João Paulo", 0,0);
            Console.WriteLine("Hello World!");
        }
    }
}
