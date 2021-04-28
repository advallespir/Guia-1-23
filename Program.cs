using System;

namespace Guia_1_23
{
    class Program
    {
        static void Main(string[] args)
        {
            fechaValida();

        }

        private static void fechaValida()
        {
            while (true)
            {
                string fecha;
                Console.WriteLine("Ingrese una fecha valida");
                fecha = Console.ReadLine();
                bool validaFecha = DateTime.TryParse(fecha, out DateTime fechaValida);
                if (!validaFecha)
                {
                    Console.WriteLine("Fecha invalida reintente");
                    continue;
                }
                else
                {
                    Console.WriteLine("La fecha es correcta");
                    Console.WriteLine(fechaValida);
                    break;
                }
            }
        }
    }
}
