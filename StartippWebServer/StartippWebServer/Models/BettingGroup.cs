using System.Collections.Generic;
using System.Security.AccessControl;

namespace StartippWebServer.Models
{
    public class BettingGroup : Entity
    {
        public virtual string Name { get; set; }
        public virtual IList<Better> Betters { get; set; }
        public virtual IList<Tournament> Tournaments { get; set; }
    }
}