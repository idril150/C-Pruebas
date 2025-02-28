using Pokemon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemons
{
    public class MovimientoModel:TipoModes
    {
        public required string TName { get; set; }
        public required List<string> Ventajas { get; set; }
        public required List<string> Desventajas { get; set; }
        public int ModVentaja { get; set; }
        public int ModDesventaja { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public int Damage {  get; set; }

    }
}
