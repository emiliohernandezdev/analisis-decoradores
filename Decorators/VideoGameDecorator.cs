using videojuegos.Models;

namespace videojuegos.Decorators
{
    public abstract class VideoGameDecorator: Videogame
    {
        protected Videogame decoratedVideoGame;

        public VideoGameDecorator(Videogame videogame)
        {
            this.decoratedVideoGame = videogame;
        }

        public override void Play()
        {
            decoratedVideoGame.Play();
        }
    }
}
