using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CalculadoraDePrestamos.Models;

namespace CalculadoraDePrestamos.DAL
{
    public class GeneralContext : DbContext
    {
        public GeneralContext() : base("Conexion") { }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
    }
}