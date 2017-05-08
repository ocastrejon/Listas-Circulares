using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class Base
    {
        private string Nombre;
        public string _Nombre { get { return _Nombre; } set { _Nombre = value; } }
        private int Minutos;
        public int _Minutos { get { return _Minutos; } set { _Minutos = value; } }

        public Base siguiente { get; set; }

        public Base()
        {
            _Nombre = "";
            _Minutos = 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
