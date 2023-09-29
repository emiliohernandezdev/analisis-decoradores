using videojuegos.Decorators;
using videojuegos.Models;

class Program
{
    static void Main()
    {

        //Compra de juego base
        Videogame videogame = new BaseGame("Super Mario Bros", 59);
        videogame.Play();

        Console.ReadKey();

        //Compra de un juego con descuento, decorador descuento quita 15 dolares al precio.
        Videogame discountVideoGame = new DiscountDecorator(videogame, 15);
        discountVideoGame.Play();

        Console.ReadKey();

        //Comprar juego con contenido descargable (DLC)
        Videogame dlcVideoGame = new DLCDecorator(videogame, "Luigui, Toad y Wario Gratis.");
        dlcVideoGame.Play();

        Console.ReadKey();
    }
}
