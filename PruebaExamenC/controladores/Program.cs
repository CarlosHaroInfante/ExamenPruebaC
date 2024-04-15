using Microsoft.VisualBasic;
using PruebaExamenC.Dtos;
using PruebaExamenC.servicios;

namespace PruebaExamenC.controladores
{

    class Program
    {


        public static void Main(string[] args)
        {
            List<vehiculosDto> vehiculos = new List<vehiculosDto>();
            List<puertasDto> puertas = new List<puertasDto>();
            MenuInterfaz menu = new MenuImplementacion();
            OperativaInterfaz operativa = new OperativaImplementacion();

            bool cerrarMenu = false;

            while(!cerrarMenu) {

                int op = menu.opMenu();

                switch (op)
                {

                    case 0:
                        Console.WriteLine("Se cierra el menú");
                        cerrarMenu=true;
                        break;
                    case 1:
                        Console.WriteLine("Registrar nuevo vehículo");
                        operativa.registrarVehiculo();
                        break;
                    default:
                        Console.WriteLine("Ninguna opción válida seleccionada, vuelva a intentarlo");
                        break;

                }
            }

        }
    }

}
