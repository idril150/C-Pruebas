using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Interfaces
{
    interface ITipo
    {
        int Id { get; }
        string TName { get; set; }
        List<int> Ventajas { get; set; }
        List<int> Desventajas { get; set; }
        int ModVentaja {  get; set; }
        int ModDesventaja { get; set; }
    }

    interface IPokemon 
    {
        int id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        float Hp { get; set; }
        int Pc { get; set; }
    }
}
