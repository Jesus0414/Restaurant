using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Platillos> platillos = new List<Platillos>();

            Platillos Sandwich = new Platillos("101", "sandwich", "Es un sandwich, no necesita una descripcion.", 68);

            Ingredientes pan = new Ingredientes("pan", "11");
            Ingredientes mayonesa = new Ingredientes("mayonesa", "12");
            Ingredientes jamon = new Ingredientes("jamon", "13");
            Ingredientes lechuga = new Ingredientes("lechuga", "14");

            Sandwich.Ingredientess.Add(pan);
            Sandwich.Ingredientess.Add(mayonesa);
            Sandwich.Ingredientess.Add(jamon);
            Sandwich.Ingredientess.Add(lechuga);

            platillos.Add(Sandwich);

            foreach(Platillos platillo in platillos)
            {
                Console.WriteLine("Platillo: " + platillo.Nombre + "\nDescripcion: " + platillo.Descripcion);
                Console.WriteLine("\nLista de ingredientes:\n");

                foreach(Ingredientes ingredientes in platillo.Ingredientess)
                {
                    Console.WriteLine("-" + ingredientes.Nombre + "\n");
                }
            }
            Console.Read();
        }
    }
}
