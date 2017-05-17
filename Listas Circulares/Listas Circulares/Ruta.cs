using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class Ruta
    {
        public Base inicio { get; set; }
        public Base ultimo { get; set; }

        public void Agregar(Base nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = inicio;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.anterior = ultimo;
                ultimo = nuevo;
                ultimo.siguiente = inicio;
            }
            
        }

        public Base Buscar(string nombre)
        {
            Base x = null;
            Base b = inicio;

            while (b != ultimo)
            {
                if (b.Nombre == nombre)
                {
                    x = b;
                    break;
                }
                else
                    b = b.siguiente;
            }
            return x;
        }

        public string Reporte()
        {
            string datos = "";
            Base b = inicio.siguiente;
            datos += inicio;
            while (b != inicio)
            {
                datos += Environment.NewLine + b.ToString();
                b = b.siguiente;
            }
            return datos;
        }

        public void Eliminar(string nombre)
        {
            if (inicio != null)
            {
                Base b = inicio;
                if (inicio.Nombre == nombre)
                    inicio = inicio.siguiente;
                else
                    while (b != ultimo)
                    { 
                        if (b.siguiente.Nombre == nombre)
                        {
                            b.siguiente = b.siguiente.siguiente;
                            break;
                        }
                        else
                            b = b.siguiente;
                    }
            }
        }

        public void AgregarInicio(Base nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = inicio;
            }
            else
            {
                nuevo.siguiente = inicio;
                inicio = nuevo;
                inicio.anterior = null;
            }
        }

        public void EliminarUltimo()
        {
            if (inicio != null)
            {
                ultimo = ultimo.anterior;
                ultimo.siguiente = null;
            }
        }

        public void EliminarPrimero()
        {
            if (inicio != null)
            {
                inicio = inicio.siguiente;
                inicio.anterior = null;
            }
        }

        public void InsertarDespuesDe(string nombre, Base nuevo)
        {
            Base b = inicio;

            while (b != ultimo)
            {
                if (b.siguiente.Nombre == nombre)
                {
                    nuevo.siguiente = b.siguiente.siguiente;
                    b.siguiente.siguiente = nuevo;
                    break;
                }
                else
                    b = b.siguiente;
            }
        }

        public string Recorrido(string nombre, DateTime inicioH, DateTime finalH)
        {
            string datos = "";
            string x = "Error";
            Base b = inicio;

            while(b != ultimo)
            {
                if (nombre == b.Nombre)
                {
                    while (inicioH < finalH)
                    {
                        inicioH = inicioH.AddMinutes(b.Minutos);
                        if (inicioH <= finalH)
                        {
                            datos += b + inicioH.ToShortTimeString() + Environment.NewLine.ToString();
                            b = b.siguiente;
                        }
                    }
                    return datos;
                }
                b = b.siguiente;
            }
            return x;
        }
    }
}
