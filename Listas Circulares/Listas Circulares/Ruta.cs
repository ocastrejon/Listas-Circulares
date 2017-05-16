using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class Ruta
    {//DateTime
        public Base inicio { get; set; }
        public Base ultimo { get; set; }
        DateTime tiempo = new DateTime();


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
            }
            
        }

        public Base Buscar(string nombre)
        {
            Base x = null;
            Base b = inicio;

            while (b != null)
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
            Base b = inicio;
            while (b != null)
            {
                datos += b.ToString();
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
                    while (b != null)
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

        public void InsertarDespuesDe(string nombre, Base b)
        {

        }

        public string Recorrido(string nombre, DateTime x, DateTime y)
        {
            string datos = "";
            Base b = inicio;
            while (b != null)
            {
                x.AddMinutes(b.Minutos);
                datos += b + x.ToString();
                b = b.siguiente;
            }
            return datos;
        }
    }
}
