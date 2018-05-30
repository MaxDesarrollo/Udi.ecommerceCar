﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udi.ecommerceCar.Data.Domain.Entities
{
    public class VehiculoDto
    {
        public int VehiculoID { get; set; }
        // CAMBIAR a INT
        public int? CantidadDisponible { get; set; }
        public decimal? Precio { get; set; }
        public string Color { get; set; }

        ////////////Mala idea? la Ñ 
        // CAMBIAR A DATETIME
        public DateTime Año { get; set; }

        public int? ModeloID { get; set; }
        public int? CantidadPuertas { get; set; }
        public bool? HabilitadoTestDrive { get; set; }
        public bool? Estado { get; set; }
        public string NombreModelo { get; set; }
        public int MarcaID { get; set; }
        public string NombreMarca { get; set; }
        public string PaisOrigen { get; set; }
        public int? TipoVehiculoID { get; set; }
        public string NombreTipoVehiculo { get; set; }
        public int? TipoCajaID { get; set; }
        public string NombreTipoCaja { get; set; }

        public Nullable<int> ImagenID { get; set; }

        public Nullable<bool> VisibleMain { get; set; }
        public Nullable<int> Puntuacion { get; set; }
     
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }

    }
}
