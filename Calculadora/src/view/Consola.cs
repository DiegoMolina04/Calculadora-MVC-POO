using Calculadora.src.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.src.view
{
    internal class Consola
    {
        public void Menu()
        {
            Console.WriteLine(
                "1. Suma\n" +
                "2. Resta\n" +
                "3. Multiplicación\n" +
                "4. División\n" +
                "5. Operaciones guardadas\n" +
                "6. Salir");

            try {
                int opcion = int.Parse(Console.ReadLine());
                ConsolaController controller = new ConsolaController();
                controller.controllerConsola(opcion);

            }
            catch (Exception ex) {
                Console.WriteLine("Error !", ex);
            }
            
        }

        public int valor()
        {

            return 1550;
        }
    }
}
