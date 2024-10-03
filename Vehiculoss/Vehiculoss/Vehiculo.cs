using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculoss
{
    public class Vehiculo
    {
        public string Modelo { get; set; }
        public double Precio { get; set; }
       public double result { get; set; }
        public string temporada { get; set; }
        public Vehiculo(string Modelo1, double Precio1,string Temporada) 
        {
            Modelo = Modelo1;
            Precio = Precio1;
            temporada = Temporada;
            Descuento descuento = new Descuento(Precio,Modelo);
            result = descuento.PrecioDescuento;
    }
        internal class Descuento
        { 
           public double PrecioDescuento { get; set; }
            public Descuento(double Precio2,string temporada)
            {
                if (temporada == "verano")
                { PrecioDescuento = (Precio2 * (1 - 0.15)); }
                else if (temporada == "invierno") 
                { PrecioDescuento = (Precio2 * (1 - 0.25)); }
               
              
            }
            
        }

    }
}
