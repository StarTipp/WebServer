namespace StartippWebServer.Models
{
    /// <summary>
    /// Base class for all entities being stored in the databases.
    /// </summary>
    public abstract class Entity
    {
        public virtual int Id { get; set; }
    }
}