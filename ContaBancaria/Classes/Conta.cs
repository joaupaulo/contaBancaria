using ContaBancaria.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Classes
{
    class Conta
    {

        private Enum.TipoConta tipoConta { get; set; }
        public string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }

        public Conta( TipoConta tipoConta, string Nome , Double Saldo, Double Credito )
        {
            this.Saldo = Saldo;
            this.tipoConta = tipoConta;
            this.Nome = Nome;
            this.Saldo = Saldo;
            this.Credito = Credito;

        }

        public bool Sacar(double valorSaque)
        {
            if(this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }

            this.Saldo -= valorSaque;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);

            return true;
        }


        public void Deposito(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Deposito(valorTransferencia)
            }
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta" + this.tipoConta + " | ";
            retorno += "Nome" + this.Nome + " | ";
            retorno += "Saldo" + this.Saldo + " | ";
            retorno += "Credito" + this.Credito + " | ";

            return retorno;
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }


    }
}
