﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Udi.ecommerceCar.Api.Models;
using Udi.ecommerceCar.Data.Domain.Entities;
using Udi.ecommerceCar.Data.Domain.Services;

namespace Udi.ecommerceCar.Api.Controllers
{
    public class VehiculoController : ApiController
    {
        private readonly VehiculoServicio vehiculoServicio = new VehiculoServicio();

        [Route("api/vehiculo/get")]
        [HttpPost]
        public IHttpActionResult Sincronizar([FromBody]ParametroApi<List<string>> Parametros)
        {
            try
            {
                string fecha = Parametros.DatoStr;

                DateTime date = DateTime.ParseExact("1990-01-01T00:00:00", "yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture);
                bool PrimeraVez = true;
                if (!string.IsNullOrEmpty(fecha) && !fecha.Equals("1990-01-01T00:00:00"))
                {
                    date = DateTime.ParseExact(fecha, "yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture);
                    PrimeraVez = false;
                }




                var Resultado = vehiculoServicio.ObtenerVehiculosTodos();

                return Ok(RespuestaApi<List<VehiculoDto>>.createRespuestaSuccess(Resultado));
            }
            catch (Exception ex)
            {
                return Ok(RespuestaApi<string>.createRespuestaError(ex.Message));
                throw;
            }

        }



        [Route("api/vechiculo/obtener")]
        [HttpPost]
        public IHttpActionResult ObtenerPorId([FromBody]ParametroApi<int> Parametros)
        {
            try
            {
                int ProductoId = Parametros.DatoG;

                var Resultado = vehiculoServicio.ObtenerVehiculo(ProductoId);

                return Ok(RespuestaApi<VehiculoDto>.createRespuestaSuccess(Resultado));
            }
            catch (Exception ex)
            {
                return Ok(RespuestaApi<string>.createRespuestaError(ex.Message));
                throw;
            }

        }

    }
}

