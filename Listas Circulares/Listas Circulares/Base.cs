using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class Base
    {
        private string _Nombre;
        public string Nombre { get { return _Nombre; } set { _Nombre = value; } }
        private double _Minutos;
        public double Minutos { get { return _Minutos; } set { _Minutos = value; } }

        public Base siguiente { get; set; }
        public Base anterior { get; set; }

        public Base()
        {
            _Nombre = "";
            _Minutos = 0;
            siguiente = null;
        }

        public override string ToString()
        {
            return Nombre + ": " + Minutos + "min.   ".ToString();
        }
    }
}
