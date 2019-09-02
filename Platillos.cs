using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Platillos
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public List<Ingredientes> Ingredientess { get; set; }


        public Platillos(string identificador, string nombre, string descripcion, double precio)
        {
            Identificador = identificador;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Ingredientess = new List<Ingredientes>();
        }

    }
}
