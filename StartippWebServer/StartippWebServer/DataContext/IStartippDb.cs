using System;
using System.Collections.Generic;
using StartippWebServer.Models;

namespace StartippWebServer.DataContext
{
    public interface IStartippDb : IDisposable
    {
        IList<Tournament> Tournaments { get; set; } 

        IList<BettingGroup> BettingGroups { get; set; } 

        IList<Better> Better { get; set; }

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
