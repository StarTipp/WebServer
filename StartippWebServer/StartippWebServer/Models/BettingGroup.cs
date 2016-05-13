using System.Collections.Generic;

namespace StartippWebServer.Models
{
    public class BettingGroup : Entity
    {
        public virtual string Name { get; set; }
        public virtual IList<Better> Betters { get; set; }
        public virtual IList<Tournament> Tournaments { get; set; }
        public virtual IList<GameBet> GameBets { get; set; }
    }
}