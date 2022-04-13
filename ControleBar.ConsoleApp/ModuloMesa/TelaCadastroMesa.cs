using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    internal class TelaCadastroMesa : TelaBase, ITelaCadastravel
    {
        private readonly IRepositorio<Mesa> _repositorioMesa;
        private readonly Notificador _notificador;

        public TelaCadastroMesa(IRepositorio<Mesa> repositorioMesa, Notificador notificador)
            : base("Cadastro de mesas")
        {
            _repositorioMesa = repositorioMesa;
            _notificador = notificador;
        }

        public void Inserir()
        {
            MostrarTitulo("Cadastro de mesa");

            Mesa novaMesa = ObterMesa();

            _repositorioMesa.Inserir(novaMesa);

            _notificador.ApresentarMensagem("Mesa cadastrada com sucesso!", TipoMensagem.Sucesso);
        }

        public void Editar()
        {
            MostrarTitulo("Editando mesa");

            bool temRegistrosCadastrados = VisualizarRegistros("Pesquisando");

            if (temRegistrosCadastrados == false)
            {
                _notificador.ApresentarMensagem("Nenhuma mesa cadastrada para editar.", TipoMensagem.Atencao);
                return;
            }

            int numeroMesa = ObterNumeroMesa();

            Mesa mesaAtualizada = ObterMesa();

            bool conseguiuEditar = _repositorioMesa.Editar(numeroMesa, mesaAtualizada);

            if (!conseguiuEditar)
                _notificador.ApresentarMensagem("Não foi possível editar.", TipoMensagem.Erro);
            else
                _notificador.ApresentarMensagem("Mesa editada com sucesso!", TipoMensagem.Sucesso);
        }

        public void Excluir()
        {
            MostrarTitulo("Excluindo Mesa");

            bool temMesasRegistradas = VisualizarRegistros("Pesquisando");

            if (temMesasRegistradas == false)
            {
                _notificador.ApresentarMensagem("Nenhuma mesa cadastrada para excluir.", TipoMensagem.Atencao);
                return;
            }

            int numeroMesa = ObterNumeroMesa();

            bool conseguiuExcluir = _repositorioMesa.Excluir(numeroMesa);

            if (!conseguiuExcluir)
                _notificador.ApresentarMensagem("Não foi possível excluir.", TipoMensagem.Erro);
            else
                _notificador.ApresentarMensagem("Mesa excluída com sucesso!", TipoMensagem.Sucesso);
        }

        public bool VisualizarRegistros(string tipoVisualizacao)
        {
            if (tipoVisualizacao == "Tela")
                MostrarTitulo("Visualização de Mesas cadastradas");

            List<Mesa> mesas = _repositorioMesa.SelecionarTodos();

            if (mesas.Count == 0)
            {
                _notificador.ApresentarMensagem("Nenhuma mesa cadastrada.", TipoMensagem.Atencao);
                return false;
            }

            foreach (Mesa mesa in mesas)
                Console.WriteLine(mesa.ToString());

            Console.ReadLine();

            return true;
        }

        private Mesa ObterMesa()
        {
            Console.WriteLine("Digite o número da mesa: ");
            int numeroDaMesa = Convert.ToInt32(Console.ReadLine());

            bool temCliente = false;

            return new Mesa(numeroDaMesa, temCliente);
        }

        private int ObterNumeroMesa()
        {
            int numeroDaMesa;
            bool numeroMesaEncontrado;

            do
            {
                Console.Write("Digite o número da mesa que deseja selecionar: ");
                numeroDaMesa = Convert.ToInt32(Console.ReadLine());

                numeroMesaEncontrado = _repositorioMesa.ExisteRegistro(numeroDaMesa);

                if (numeroMesaEncontrado == false)
                    _notificador.ApresentarMensagem("ID do produto não foi encontrado, digite novamente", TipoMensagem.Atencao);

            } while (numeroMesaEncontrado == false);

            return numeroDaMesa;
        }
    }
}
