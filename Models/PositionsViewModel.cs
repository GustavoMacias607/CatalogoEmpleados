using CatalogoEmpleados.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogoEmpleados.Service
{
    public class PositionsViewModel
    {
        public List<PositionsGustavo> datos { get; set; }
        public int Id { get; set; }
        public string posicion  { get; set; }
    }
}