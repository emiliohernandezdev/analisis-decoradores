using videojuegos.Models;

namespace videojuegos.Decorators
{
    public class DLCDecorator: VideoGameDecorator
    {
        private string downloadableContent;

        public DLCDecorator(Videogame videogame, string content): base(videogame)
        {
            downloadableContent = content;
            Price = videogame.Price + 15; 
        }

        public override void Play()
        {
            base.Play();
            Console.Write($"Se agrega contenido descargable: {downloadableContent}");
        }
    }
}
