using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Producto;
namespace Producto
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;
        private int capacidad;
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            string aux="";
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < e.capacidad; i++)
            {
                aux = e.productos[i].MostrarProducto(e.productos[i]);
                str.AppendFormat("{0} {1}", str, aux);
            }
            return str.ToString();
        }
        public static bool operator ==(Estante p1, Producto p2)
        {
            Producto aux = new Producto();
            for(int i=0;i<p1.capacidad;i++)
            {
                aux = p1.productos[i];
                if (aux==p2)
                    return true;

            }
            return false;
        }
            /*Sobrecarga de operadores:
            Igualdad, retornará true, si es que el producto ya se encuentra en el estante, false, caso contrario.
            Adición, retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y
            dicho producto no se encuentra en él; false, caso contrario.Reutilizar código.
            Sustracción (Estante, Producto), retornará un estante sin el producto, siempre y cuando el producto se encuentre en el
            listado. Reutilizar código.*/
    }
}
