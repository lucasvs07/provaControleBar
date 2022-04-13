using ControleBar.ConsoleApp.ModuloConta;
using ControleBar.ConsoleApp.ModuloGarcom;
using ControleBar.ConsoleApp.ModuloMesa;
using ControleBar.ConsoleApp.ModuloProduto;
using System;

namespace ControleBar.ConsoleApp.Compartilhado
{
    public class TelaMenuPrincipal
    {
        private readonly IRepositorio<Garcom> repositorioGarcom;
        private readonly TelaCadastroGarcom telaCadastroGarcom;

        private readonly IRepositorio<Produto> repositorioProduto;
        private readonly TelaCadastroProduto telaCadastroProduto;

        private readonly IRepositorio<Mesa> repositorioMesa;
        private readonly TelaCadastroMesa telaCadastroMesa;

        private readonly IRepositorio<Conta> repositorioConta;
        private readonly TelaCadastroConta telaCadastroConta;

        public TelaMenuPrincipal(Notificador notificador)
        {
            repositorioGarcom = new RepositorioGarcom();
            telaCadastroGarcom = new TelaCadastroGarcom(repositorioGarcom, notificador);

            repositorioProduto =  new RepositorioProduto();
            telaCadastroProduto = new TelaCadastroProduto(repositorioProduto, notificador);

            repositorioMesa = new RepositorioMesa();
            telaCadastroMesa = new TelaCadastroMesa(repositorioMesa, notificador);

            repositorioConta = new RepositorioConta();
            telaCadastroConta = new TelaCadastroConta(repositorioConta, notificador);

            PopularAplicacao();
        }

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Controle de Mesas de Bar 1.0");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para gerenciar contas");

            Console.WriteLine("Digite 2 para gerenciar produtos");

            Console.WriteLine("Digite 3 para gerenciar garçons");

            Console.WriteLine("Digite 4 para gerenciar mesas");

            Console.WriteLine("Digite s para sair");

            string opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        public TelaBase ObterTela()
        {
            string opcao = MostrarOpcoes();

            TelaBase tela = null;

            if (opcao == "1")
                tela = telaCadastroConta;

            else if (opcao == "2")
                tela = telaCadastroProduto;

            else if (opcao == "3")
                tela = telaCadastroGarcom;

            else if (opcao == "4")
                tela = telaCadastroMesa;

            else if (opcao == "5")
                tela = null;

            return tela;
        }

        private void PopularAplicacao()
        {
            var garcom = new Garcom("Julinho", "230.232.519-98");
            repositorioGarcom.Inserir(garcom);
        }
    }
}
