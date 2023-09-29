namespace videojuegos.Models
{
    public class BaseGame: Videogame
    {
        public BaseGame(string name, decimal price) { 
            Name = name;
            Price = price;
        }

        public override void Play()
        {
            Console.WriteLine($"Jugando: {Name}");
        }
    }
}
