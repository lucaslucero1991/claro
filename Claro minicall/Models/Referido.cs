using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Claro_minicall.Models
{
    /// <summary>
    /// Clase POCO (Plain Old CRL Object), solo tiene informacion, no tiene funcionalidad
    /// solo representa un estado del un objeto, no tiene logica, solo propiedades
    /// que se usan para representar un estado.
    /// </summary>
    public class Referido
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}