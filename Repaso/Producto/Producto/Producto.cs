using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    class Producto
    {
        string codigoDeBarra;
        string marca;
        float precio;
        public Producto()
        {

        }
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public string MostrarProducto(Producto p)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Marca: {0}\nCodigo de Barra: {1}\nPrecio: {2}", p.marca, p.codigoDeBarra, p.precio);
            return builder.ToString();
        }
        public static bool operator ==(Producto p, string marca)
        {
           // if (p.marca == marca)
               // return true;
            return (p.marca == marca);
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            if(p1.marca == p2.marca && p1.codigoDeBarra==p2.codigoDeBarra)
                return true;
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1==p2);
        }
    }
}
