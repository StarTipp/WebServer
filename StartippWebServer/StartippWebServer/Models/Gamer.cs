using System.Collections.Generic;

namespace StartippWebServer.Models
{
    /// <summary>
    /// Gamer participating in the starcraft tournament.
    /// </summary>
    public class Gamer : Entity
    {
        /// <summary>
        /// Name of the gamer.
        /// </summary>
        public virtual string Name { get; set; }

        public IList<Game> Games { get; set; }
    }
}