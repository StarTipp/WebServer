using System.Collections.Generic;
using System.Data.Entity;
using StartippWebServer.Models;

namespace StartippWebServer.DataContext
{
    public class StartippDb : DbContext, IStartippDb
    {
        public virtual IList<Better> Better { get; set; }
        public virtual IList<BettingGroup> BettingGroups { get; set; }
        public virtual IList<Game> Games { get; set; }
        public virtual IList<GameBet> GameBets { get; set; }
        public virtual IList<Gamer> Gamer { get; set; }
        public virtual IList<PointPolicy> PointPolicies { get; set; }
        public virtual IList<Tournament> Tournaments { get; set; }
        public virtual IList<TournamentRound> TournamentRounds { get; set; }

        protected virtual DbSet<Better> BetterDbSet { get; set; }
        protected virtual DbSet<BettingGroup> BettingGroupsDbSet { get; set; }
        protected virtual DbSet<Game> GamesDbSet { get; set; }
        protected virtual DbSet<GameBet> GameBetsDbSet { get; set; }
        protected virtual DbSet<Gamer> GamerDbSet { get; set; }
        protected virtual DbSet<PointPolicy> PointPoliciesDbSet { get; set; }
        protected virtual DbSet<Tournament> TournamentsDbSet { get; set; }
        protected virtual DbSet<TournamentRound> TournamentRoundsDbSet { get; set; }

        public StartippDb() : base("DefaultConnection")
        {

        }

        public void ResetAllData()
        {
            throw new System.NotImplementedException();
        }
    }
}