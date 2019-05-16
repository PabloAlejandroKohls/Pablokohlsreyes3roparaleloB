using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabloKohls3B
{
    public class ClientePablo
    {
        private string apellidos;
                public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private int identificacion;

        public int Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }        
        private string tipo;

        public ClientePablo(string apellidos, string nombres, int numero, int identificacion, string direccion, string tipo)
        {
            Apellidos = apellidos;
            Nombres = nombres;
            Numero = numero;
            Identificacion = identificacion;
            Direccion = direccion;
            Tipo = tipo;
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


    }

    }





    

