using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculoss
{
    public class Program
    {
        static void Main(string[] args)
        {
            double price = 100;
            string modelo = "KIA";
            string temporada = "invierno";
            Vehiculo vehiculo = new Vehiculo(modelo,price,temporada);
            Console.WriteLine( $"Modelo: {vehiculo.Modelo}||" +
                $"Precio: {vehiculo.Precio}||" +
                $"PrecioDescuento: {vehiculo.result}");
            Console.ReadLine();
        }
    }
}
