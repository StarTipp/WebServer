using System.Collections.Generic;

namespace StartippWebServer.Models
{
    public class Tournament : Entity
    {
        public virtual string Name { get; set; }
        public virtual IList<BettingGroup> BettingGroups { get; set; }
        public virtual IList<TournamentRound> TournamentRounds { get; set; }
        public virtual IList<GameBet> GameBets { get; set; }
    }
}