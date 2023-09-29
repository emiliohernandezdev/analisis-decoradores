using videojuegos.Models;

namespace videojuegos.Decorators
{
    public class DiscountDecorator: VideoGameDecorator
    {
        private decimal Discount;
        private decimal OriginalPrice;

        public DiscountDecorator(Videogame videogame, decimal discount): base(videogame)
        {
            this.Discount = discount;
            this.OriginalPrice = videogame.Price;
            Price = videogame.Price - discount;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Se aplica descuento. Precio anterior: {OriginalPrice}, Precio Nuevo: {Price}");
        }
    }
}
