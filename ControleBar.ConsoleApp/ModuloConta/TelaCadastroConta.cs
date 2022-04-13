using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloConta
{
    public class TelaCadastroConta : TelaBase, ITelaCadastravel
    {
        private readonly IRepositorio<Conta> _repositorioConta;
        private readonly Notificador _notificador;

        public TelaCadastroConta(IRepositorio<Conta> repositorioConta, Notificador notificador)
            : base("Cadastro de Conta")
        {
            _repositorioConta = repositorioConta;
            _notificador = notificador;
        }


        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }

        public void Inserir()
        {
            throw new NotImplementedException();
        }

        public bool VisualizarRegistros(string tipoVisualizacao)
        {
            throw new NotImplementedException();
        }
    }
}

