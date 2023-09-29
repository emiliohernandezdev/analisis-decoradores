using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojuegos.Models
{
    public abstract class Videogame
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }

        public abstract void Play();
    }
}
