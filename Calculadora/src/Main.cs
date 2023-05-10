using Calculadora.src.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Calculadora.src.view.Consola;

namespace Calculadora.src
{
    internal class main
    {
        static void Main(string[] args)
        {
            Consola console = new Consola();
            console.Menu(); //Se inicia el menu
        }
    }
}
