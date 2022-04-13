using ControleBar.ConsoleApp.Compartilhado;
using ControleBar.ConsoleApp.ModuloGarcom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public int NumeroDaMesa { get; set; }
        public bool TemCliente { get; set; }

        public Mesa(int numeroDaMesa, bool temCliente)
        {
            NumeroDaMesa = numeroDaMesa;
            TemCliente = temCliente;
        }

        public override string ToString()
        {
            return "Número da mesa: " + NumeroDaMesa + Environment.NewLine +
                "Tem cliente usando a mesa: " + TemCliente + Environment.NewLine;
        }

    }
}
