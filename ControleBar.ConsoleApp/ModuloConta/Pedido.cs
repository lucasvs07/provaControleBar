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
    public class Pedido : TelaBase
    {
        private readonly Notificador _notificador;

        public string pedido { get; set; }
        public string MesaDoPedido { get; set; }

        public Produto produto;

        public Mesa mesaDoPedido;

        public Pedido(Garcom garcom, Produto produto, Mesa MesaDoPedido) : base("Novo pedido")
        {
            MesaDoPedido ;
        }

        public Pedido NovoPedido()
        {
            MostrarTitulo("Novo pedido");

            Pedido novoPedido = ObterPedido();

            _notificador.ApresentarMensagem("Pedido realizado com sucesso!", TipoMensagem.Sucesso);

            return novoPedido;
        }

        private Pedido ObterPedido()
        {
            Console.WriteLine("Digite o número da mesa do pedido: ");
            string mesaDoPedido = Console.ReadLine();

            Console.WriteLine("Digite o garçom responsável:");
            string garcomResponsavel = Console.ReadLine();

            
            return new Pedido(garcomResponsavel, mesaDoPedido);
            



        }
    }
}
