using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeSort
{
    public  class Pastel
    {
        public string Sabor { get; set; }
        public int tamanio { get; set; }
        public string color { get; set; }
        public double precio { get; set; }
        public int porciones { get; set; }
        public double peso { get; set; }
        public string proveedor { get; set; }

        public Pastel(string sabor, int tamanio, string color, double precio, int porciones, double peso, string proveedor)
        {
            Sabor = sabor;
            this.tamanio = tamanio;
            this.color = color;
            this.precio = precio;
            this.porciones = porciones;
            this.peso = peso;
            this.proveedor = proveedor;
        }
    }
}
