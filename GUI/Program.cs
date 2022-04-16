using System;
using System.Threading;

namespace GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----GUI-----");
            Console.WriteLine("Escriba el rango (ejemplo 1,5): ");
            string mensaje = Console.ReadLine();
            Cliente cliente = new Cliente();

            //mandar primer rango
            //ip mensaje y puerto
            cliente.Connect("", mensaje, "8888");

            Thread.Sleep(1000);

            cliente.RecibirMensaje();

            cliente.CerrarCliente();

            Console.ReadKey();

        }


    }
}
