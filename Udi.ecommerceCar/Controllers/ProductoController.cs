﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Udi.ecommerceCar.Data.Domain.Entities;
using Udi.ecommerceCar.Data.Domain.Services;
using Udi.ecommerceCar.Data.Infrastructure.Data.DataModels;

namespace Udi.ecommerceCar.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ProductoServicio productoServicio = new ProductoServicio();
        
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detalle(int id)
        {
            ProductoDto producto = productoServicio.ObtenerProducto(id);
            return producto != null ? View(producto) : View();
        }

        public JsonResult GuardarProducto(string nombre, string descripcion, int cantidad, int tipoProductoId)
        {
            try
            {
                //Producto prod = ComunServicio.ObtenerDtoFromString<Producto>(producto);
                int id = productoServicio.ObtenerProductosTodos().Count;
                ProductoDto prod = new ProductoDto()
                {
                    ProductoID = id + 1,
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Cantidad = cantidad,
                    TipoProductoID = tipoProductoId
                };
                int pk = productoServicio.GuardarProducto(prod);

                return new JsonResult { Data = new { Success = true, Data = pk } };
            }
            catch (Exception ex)
            {
                return new JsonResult { Data = new { Success = false, Mensaje = ex.Message } };
            }
        }

        public JsonResult ObtenerProducto(int pk)
        {
            try
            {
                var data = productoServicio.ObtenerProducto(pk);

                if (data == null)
                {
                    return new JsonResult { Data = new { Success = false} };
                }

                return new JsonResult { Data = new { Success = true, Data = data } };
            }
            catch (Exception ex)
            {
                return new JsonResult { Data = new { Success = false, Mensaje = ex.Message } };
            }
        }

        public JsonResult ObtenerProductosTodos()
        {
            try
            {
                var data = productoServicio.ObtenerProductosTodos();

                return new JsonResult { Data = new { Success = true, Data = data } };
            }
            catch (Exception ex)
            {
                return new JsonResult { Data = new { Success = false, Mensaje = ex.Message } };
            }
        }

        public JsonResult ObtenerProductos(int page, int size)
        {
            try
            {

                var data = productoServicio.ObtenerProductos(page, size);

                return new JsonResult { Data = new { Success = true, Data = data } };
            }
            catch (Exception ex)
            {
                return new JsonResult { Data = new { Success = false, Mensaje = ex.Message } };
            }
        }
    }
}