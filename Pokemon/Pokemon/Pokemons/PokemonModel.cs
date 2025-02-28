using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon.Interfaces;

namespace Pokemon.Pokemons
{
    public class PokemonModel : IPokemon
    { 
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Hp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Pc { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TipoModes Tipo {get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PokemonModel() { }



    } 
    public class TipoModes : ITipo
    {
        public int Id => throw new NotImplementedException();
        public string TName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<int> Ventajas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<int> Desventajas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ModVentaja { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ModDesventaja { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float ModHp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}