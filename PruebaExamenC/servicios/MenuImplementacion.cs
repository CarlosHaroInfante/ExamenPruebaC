using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamenC.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int opMenu()
        {

            Console.WriteLine("--------------------");
            Console.WriteLine("Zona Sur");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Registrar un nuevo vehículo");
            Console.WriteLine("--------------------");

            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
            
        }
    }
}
