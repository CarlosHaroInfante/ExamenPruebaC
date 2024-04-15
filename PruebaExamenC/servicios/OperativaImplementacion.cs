using PruebaExamenC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamenC.servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        string ruta = "C:\\Users\\Carlos\\Desktop\\Programación\\PruebaExamenC\\15042024.txt";
        public void registrarVehiculo()
        {

            List<vehiculosDto> vehiculoRegistrado = new List<vehiculosDto>();
            List<puertasDto> puerta = new List<puertasDto>();
            string control = "";


            do
            {
                vehiculosDto vehiculoNuevoRegistrado = new vehiculosDto();
                puertasDto puertaAsignada = new puertasDto();
                Console.WriteLine("Matricula");
                vehiculoNuevoRegistrado.Matricula = Console.ReadLine();



                Console.WriteLine("Tipo de vehiculo, [P (particular), F (cam. frig), A (cam. art)]");
                vehiculoNuevoRegistrado.TipoVehiculo = Console.ReadLine();
                if (vehiculoNuevoRegistrado.TipoVehiculo.Equals("P"))
                {
                    vehiculoNuevoRegistrado.ZonaDestino = puertaAsignada.PuertaOeste;
                    vehiculoNuevoRegistrado.FechaPasoControl = puertaAsignada.FechaPasoPuerta;
                }

                if (vehiculoNuevoRegistrado.TipoVehiculo != ("P")) {
                    Console.WriteLine("Mercancía [SI o NO]");
                    string controlMercancia = Console.ReadLine();

                    if (controlMercancia.Equals("SI"))
                    {
                        vehiculoNuevoRegistrado.Mercancia = true;
                    }
                    else
                    {
                        vehiculoNuevoRegistrado.Mercancia = false;
                    }
                }

                if (vehiculoNuevoRegistrado.TipoVehiculo.Equals("F") && vehiculoNuevoRegistrado.Mercancia == true)
                {

                    vehiculoNuevoRegistrado.ZonaDestino = puertaAsignada.PuertaEste;
                    vehiculoNuevoRegistrado.FechaPasoControl = puertaAsignada.FechaPasoPuerta;
                }


                if (vehiculoNuevoRegistrado.TipoVehiculo.Equals("A") && vehiculoNuevoRegistrado.Mercancia == true)
                {
                    vehiculoNuevoRegistrado.ZonaDestino = puertaAsignada.PuertaEste;
                    vehiculoNuevoRegistrado.FechaPasoControl = puertaAsignada.FechaPasoPuerta;
                }

                if (vehiculoNuevoRegistrado.TipoVehiculo.Equals("F") && vehiculoNuevoRegistrado.Mercancia == false)
                {
                    vehiculoNuevoRegistrado.ZonaDestino = puertaAsignada.PuertaNorte;
                    vehiculoNuevoRegistrado.FechaPasoControl = puertaAsignada.FechaPasoPuerta;
                }
                if (vehiculoNuevoRegistrado.TipoVehiculo.Equals("A") && vehiculoNuevoRegistrado.Mercancia == false)
                {
                    vehiculoNuevoRegistrado.ZonaDestino = puertaAsignada.PuertaNorte;
                    vehiculoNuevoRegistrado.FechaPasoControl = puertaAsignada.FechaPasoPuerta;
                }

                else
                {
                    vehiculoNuevoRegistrado.ZonaDestino = puertaAsignada.PuertaSur;
                    vehiculoNuevoRegistrado.FechaPasoControl = puertaAsignada.FechaPasoPuerta;
                }


                vehiculoNuevoRegistrado.FechaPasoControl = DateTime.Now;

                vehiculoNuevoRegistrado.Id = idAutoGen(vehiculoRegistrado);

                vehiculoRegistrado.Add(vehiculoNuevoRegistrado);

                Console.WriteLine("¿Registrar otro vehiculo? // SI o NO");
                control = Console.ReadLine();


            }
            while (control.Equals("SI"));



            

                foreach (vehiculosDto vehiculo in vehiculoRegistrado)
                {
                    Console.WriteLine(vehiculo.ToString());
            
                

                
                
                }
            }



        public void pif()
        {
            List<vehiculosDto> vehiculoRegistrado = new List<vehiculosDto>();
            vehiculosDto vehiculosEnPif = new vehiculosDto();

            foreach(vehiculosDto vehiculos in vehiculoRegistrado)
            {

            }

        }

        private long idAutoGen(List<vehiculosDto> listaVehiculos)
        {

            long id;

            int tamanioLista = listaVehiculos.Count;

            if(tamanioLista > 0)
            {
                id = listaVehiculos[tamanioLista - 1].Id + 1;
            }
            else
            {
                id = 1;
            }

            return id;
        }
    }
}
