using ControleBar.ConsoleApp.Compartilhado;
using ControleBar.ConsoleApp.ModuloGarcom;
using ControleBar.ConsoleApp.ModuloMesa;
using ControleBar.ConsoleApp.ModuloProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public Garcom garcom;

        public Mesa mesa;

        public Produto produto;

        public decimal totalDaConta;


        public Conta(Garcom garcom, Mesa mesa, Produto produto, decimal TotalDaConta)
        {
            this.garcom = garcom;
            this.mesa = mesa;
            this.produto = produto;
            TotalDaConta = totalDaConta;

            AbrirConta();
            
        }

        public void AbrirConta()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Conta da mesa: " + mesa + Environment.NewLine +
                "Garçom que atendeu: " + garcom + Environment.NewLine +
                "Valor total: R$" + totalDaConta + Environment.NewLine;
        }
    }
}
