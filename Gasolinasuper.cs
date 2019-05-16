using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabloKohls3B
{
   public  class Gasolinasuper
    {
        private int cantidadgalones;

        public Gasolinasuper(int cantidaGalones)
        {
            CantidaGalones = cantidaGalones;
        }

        public int CantidaGalones
        {
            get { return cantidadgalones; }
            set { cantidadgalones = value; }
        }
        public static Double SUBTOTAL1(Double galones)
        {
            return galones * 1.50;
        }
        public static Double totalconIVA(Double subtotal1)
        {
            Double iVA = 0.12;
            return subtotal1 * 0.12;
        }
        public static Double total(Double total, Double subtotal1)
        {
            return total + subtotal1;
        }
    }
}
