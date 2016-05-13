using System;

namespace StartippWebServer.DataContext
{
    public interface IStartippDb : IDisposable
    {
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
