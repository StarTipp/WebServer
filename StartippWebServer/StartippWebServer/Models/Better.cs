using System.Collections.Generic;

namespace StartippWebServer.Models
{
    /// <summary>
    /// The player betting on games.
    /// </summary>
    public class Better : Entity
    {
        /// <summary>
        /// ID of the ApplicationUser used for the authentication.
        /// </summary>
        public virtual string ReleatedApplicationUserId { get; set; }

        /// <summary>
        /// Name of the better.
        /// </summary>
        public virtual string Name { get; set; }

        public virtual IList<GameBet> GameBets { get; set; }

        public virtual IList<BettingGroup> BettingGroups { get; set; }
    }
}