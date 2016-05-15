using System.Collections.Generic;
using System.Data.Entity;
using StartippWebServer.Models;

namespace StartippWebServer.DataContext
{
    public class StartippDb : DbContext, IStartippDb
    {
        public virtual DbSet<Better> Better { get; set; }
        public virtual DbSet<BettingGroup> BettingGroups { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameBet> GameBets { get; set; }
        public virtual DbSet<Gamer> Gamer { get; set; }
        public virtual DbSet<PointPolicy> PointPolicies { get; set; }
        public virtual DbSet<Tournament> Tournaments { get; set; }
        public virtual DbSet<TournamentRound> TournamentRounds { get; set; }

        public StartippDb() : base("DefaultConnection")
        {
        }

        public void ResetAllData()
        {
            throw new System.NotImplementedException();
        }
    }
}