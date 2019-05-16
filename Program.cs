using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabloKohls3B
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ClientePablo Inepaca = new ClientePablo("Kohls Reyes", "Pablo Alejandro",
                    0968215449, 1316450632, "La Pradera", "extra");
                Console.WriteLine("escriba su apellido: {0}, nombre:{1}, numero:{2}, identificaion:{3}, direccion:{4}",
                      Inepaca.Apellidos, Inepaca.Nombres, Inepaca.Numero, Inepaca.Identificacion, Inepaca.Direccion);
                Gasolinaextra Extra = new Gasolinaextra(8);
                Console.WriteLine("la cantidad de gasolina que requiere es: {0}", Extra.CantidadGalones);
                Console.ReadKey();
            ClientePablo petroecuador = new ClientePablo("reyes quimis", "Rosa Sara", 0995281717, 0916887862,
                "La Pradera", "super");
            Console.WriteLine("escriba su apellido: {0}, nombre:{1}, numero:{2}, identificaion:{3}, direccion:{4}",
                  Inepaca.Apellidos, Inepaca.Nombres, Inepaca.Numero, Inepaca.Identificacion, Inepaca.Direccion);
            Gasolinasuper Super = new Gasolinasuper(10);
            Console.WriteLine("la cantidad de gasolina que requiero para mi auto es:{0}", Super.CantidaGalones);
            Console.ReadKey();

        } }
    }
}
