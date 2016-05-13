using System.Collections.Generic;

namespace StartippWebServer.Models
{
    public class TournamentRound : Entity
    {
        public virtual IList<Game> Games { get; set; }
        public virtual PointPolicy PointPolicy { get; set; }
        public virtual PlayoffFormat PlayoffFormat { get; set; }
        public virtual Tournament Tournament { get; set; }
    }

    public enum PlayoffFormat
    {
        BestOfOne = 0,
        BestOfThree,
        BestOfFive,
        BestOfSeven,
        BestOfNine
    }
}