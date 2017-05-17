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
        private int aux = 0;
        private int a = 1;

        public void Agregar(Base nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = inicio;
                aux++;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.anterior = ultimo;
                ultimo = nuevo;
                ultimo.siguiente = inicio;
                aux++;
            }
            
        }

        public Base Buscar(string nombre)
        {
            Base x = null;
            Base b = inicio;
            a = 1;

            while (a <= aux)
            {
                if (b.Nombre == nombre)
                {
                    x = b;
                    break;
                }
                else
                    b = b.siguiente;
                a++;
            }
            return x;
        }

        public string Reporte()
        {
            string datos = "";
            Base b = inicio;
            a = 1;

            while (a <= aux)
            {
                datos += b + Environment.NewLine.ToString();
                b = b.siguiente;
                a++;
            }
            return datos;
        }

        public void Eliminar(string nombre)
        {
            a = 1; 

            if (inicio != null)
            {
                Base b = inicio;
                if (inicio.Nombre == nombre)
                {
                    inicio = inicio.siguiente;
                    aux--;
                }
                else
                    while (a <= aux)
                    { 
                        if (b.siguiente.Nombre == nombre)
                        {
                            b.siguiente = b.siguiente.siguiente;
                            aux--;
                            break;
                        }
                        else
                            b = b.siguiente;
                        a++;
                    }
            }
        }

        public void AgregarInicio(Base nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = inicio;
                aux++;
            }
            else
            {
                nuevo.siguiente = inicio;
                inicio = nuevo;
                inicio.anterior = null;
                aux++;
            }
        }

        public void EliminarUltimo()
        {
            if (inicio != null)
            {
                ultimo = ultimo.anterior;
                ultimo.siguiente = null;
                aux--;
            }
        }

        public void EliminarPrimero()
        {
            if (inicio != null)
            {
                inicio = inicio.siguiente;
                inicio.anterior = null;
                aux--;
            }
        }

        public void InsertarDespuesDe(string nombre, Base nuevo)
        {
            Base b = inicio;
            a = 1;

            while (a <= aux)
            {
                if (b.siguiente.Nombre == nombre)
                {
                    nuevo.siguiente = b.siguiente.siguiente;
                    b.siguiente.siguiente = nuevo;
                    aux++;
                    break;
                }
                else
                    b = b.siguiente;
                a++;
            }
        }

        public string Recorrido(string nombre, DateTime inicioH, DateTime finalH)
        {
            string datos = "";
            string x = "Error";
            Base b = inicio;
            a = 1;

            while(a <= aux)
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
                a++;
            }
            return x;
        }
    }
}
