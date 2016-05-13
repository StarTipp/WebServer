using System.Data.Entity;

namespace StartippWebServer.DataContext
{
    public class StartippDb : DbContext, IStartippDb
    {
        public void ResetAllData()
        {
            throw new System.NotImplementedException();
        }
    }
}