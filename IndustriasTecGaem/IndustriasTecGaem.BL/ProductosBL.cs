using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustriasTecGaem.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Tarjeta Madre Estandar para Intel";
            producto1.Precio = 1500;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Procesador Intel Core i5 4800";
            producto2.Precio = 5000;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Tarjeta Grafica GT 950 2GB";
            producto3.Precio = 4500;

            var listaDeProductos = new List<Producto>();
            listaDeProductos.Add(producto1);
            listaDeProductos.Add(producto2);
            listaDeProductos.Add(producto3);
            return listaDeProductos;
        }
    }
}
