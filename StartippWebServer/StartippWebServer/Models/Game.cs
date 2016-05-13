namespace StartippWebServer.Models
{
    /// <summary>
    /// One single game of a tournament.
    /// </summary>
    public class Game : Entity
    {
        public virtual Gamer Gamer1 { get; set; }
        public virtual Gamer Gamer2 { get; set; }
        public virtual byte WinsGamer1 { get; set; }
        public virtual byte WinsGamer2 { get; set; }
        public virtual GameState GameState { get; set; }
    }

    /// <summary>
    /// Possible states of a single game.
    /// </summary>
    public enum GameState
    {
        NotStarted = 0,
        Running,
        Gamer1Won,
        Gamer2Won
    }
}