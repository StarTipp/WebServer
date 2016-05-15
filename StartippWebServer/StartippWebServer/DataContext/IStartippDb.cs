using System;
using System.Data.Entity;
using StartippWebServer.Models;

namespace StartippWebServer.DataContext
{
    public interface IStartippDb : IDisposable
    {
        DbSet<Better> Better { get; set; }
        DbSet<BettingGroup> BettingGroups { get; set; }
        DbSet<Game> Games { get; set; }
        DbSet<GameBet> GameBets { get; set; }
        DbSet<Gamer> Gamer { get; set; }
        DbSet<PointPolicy> PointPolicies { get; set; }
        DbSet<Tournament> Tournaments { get; set; }
        DbSet<TournamentRound> TournamentRounds { get; set; }

        /// <summary>
        /// Save all changes to the Database
        /// </summary>
        int SaveChanges();

        /// <summary>
        /// Removes all database entries.
        /// </summary>
        void ResetAllData();
    }
}
