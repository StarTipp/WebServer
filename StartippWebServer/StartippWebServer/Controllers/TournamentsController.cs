using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using StartippWebServer.DataContext;
using StartippWebServer.Models;

namespace StartippWebServer.Controllers
{
    public class TournamentsController : ApiController
    {
        private readonly IStartippDb _database;

        public TournamentsController(IStartippDb database)
        {
            _database = database;
        }

        // GET: api/Tournaments
        public IQueryable<Tournament> GetTournaments()
        {
            return _database.Tournaments;
        }

        // GET: api/Tournaments/5
        [ResponseType(typeof(Tournament))]
        public IHttpActionResult GetTournament(int id)
        {
            Tournament tournament = _database.Tournaments.Find(id);
            if (tournament == null)
            {
                return NotFound();
            }

            return Ok(tournament);
        }

        //// PUT: api/Tournaments/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutTournament(int id, Tournament tournament)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != tournament.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _database.Entry(tournament).State = EntityState.Modified;

        //    try
        //    {
        //        _database.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TournamentExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Tournaments
        //[ResponseType(typeof(Tournament))]
        //public IHttpActionResult PostTournament(Tournament tournament)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _database.Tournaments.Add(tournament);
        //    _database.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = tournament.Id }, tournament);
        //}

        //// DELETE: api/Tournaments/5
        //[ResponseType(typeof(Tournament))]
        //public IHttpActionResult DeleteTournament(int id)
        //{
        //    Tournament tournament = _database.Tournaments.Find(id);
        //    if (tournament == null)
        //    {
        //        return NotFound();
        //    }

        //    _database.Tournaments.Remove(tournament);
        //    _database.SaveChanges();

        //    return Ok(tournament);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _database.Dispose();
            }
            base.Dispose(disposing);
        }

        //private bool TournamentExists(int id)
        //{
        //    return _database.Tournaments.Count(e => e.Id == id) > 0;
        //}
    }
}