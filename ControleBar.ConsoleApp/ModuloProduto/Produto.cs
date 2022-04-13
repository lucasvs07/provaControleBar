using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public string nomeProduto { get; set; }
        public decimal valorUnitario { get; set; }
        public int quantidadeDisponivel { get; set; }

        public Produto (string NomeProduto, decimal ValorUnitario, int QuantidadeDisponivel)
        {
            nomeProduto = NomeProduto;
            valorUnitario = ValorUnitario;
            quantidadeDisponivel = QuantidadeDisponivel;
        }


        public override string ToString()
        {
            return "Nome do produto: " + nomeProduto + Environment.NewLine +
                "Valor unitario: R$" + valorUnitario + Environment.NewLine +
                "Quantidade disponível: " + quantidadeDisponivel + Environment.NewLine;
        }

        public void DiminuiQuantidade(int QuantidadeDisponivel)
        {
            quantidadeDisponivel -= QuantidadeDisponivel;

        }

    }
}
