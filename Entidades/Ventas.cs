﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicadoPC.Entidades
{
    public class Ventas
    {
        [Key]
        public int NumeroFactura { get; set; }
        public string Fecha { get; set; }
        public decimal Total { get; set; }
        public virtual List<DetalleVentas> Articulos { get; set; }

        public Ventas()
        {
            NumeroFactura = 0;
            Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            Total = 0;
            Articulos = new List<DetalleVentas>();
        }
    }
}
