using IndustriasTecGaem.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndustriasTecGaem.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProdutoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Tarjeta Madre Estandar para Intel";

            var producto2 = new ProdutoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Procesador Intel Core i5 4800";

            var producto3 = new ProdutoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Tarjeta Grafica GT 950 2GB";

            var listaDeProductos = new List<ProdutoModel>();
            listaDeProductos.Add(producto1);
            listaDeProductos.Add(producto2);
            listaDeProductos.Add(producto3);
            return View(listaDeProductos);
        }
    }
}