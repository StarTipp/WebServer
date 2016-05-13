namespace StartippWebServer.Models
{
    /// <summary>
    /// Defines the rating during one round.
    /// </summary>
    public class PointPolicy : Entity
    {
        /// <summary>
        /// Score obtained for predicting the winner of a game.
        /// </summary>
        public virtual byte WinPoints { get; set; }

        /// <summary>
        /// Score obtained for predicting the exact game result (wins & losses).
        /// </summary>
        public virtual byte ScorePoints { get; set; }
    }
}