using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ISPKlijenti_API.Models;

namespace ISPKlijenti_API.Controllers
{
    public class StatusiNalogaController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/StatusiNaloga
        public IQueryable<StatusiNaloga> GetStatusiNaloga()
        {
            return db.StatusiNaloga;
        }

        // GET: api/StatusiNaloga/5
        [ResponseType(typeof(StatusiNaloga))]
        public IHttpActionResult GetStatusiNaloga(int id)
        {
            StatusiNaloga statusiNaloga = db.StatusiNaloga.Find(id);
            if (statusiNaloga == null)
            {
                return NotFound();
            }

            return Ok(statusiNaloga);
        }

        // PUT: api/StatusiNaloga/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStatusiNaloga(int id, StatusiNaloga statusiNaloga)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != statusiNaloga.Id)
            {
                return BadRequest();
            }

            db.Entry(statusiNaloga).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatusiNalogaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/StatusiNaloga
        [ResponseType(typeof(StatusiNaloga))]
        public IHttpActionResult PostStatusiNaloga(StatusiNaloga statusiNaloga)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.StatusiNaloga.Add(statusiNaloga);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = statusiNaloga.Id }, statusiNaloga);
        }

        // DELETE: api/StatusiNaloga/5
        [ResponseType(typeof(StatusiNaloga))]
        public IHttpActionResult DeleteStatusiNaloga(int id)
        {
            StatusiNaloga statusiNaloga = db.StatusiNaloga.Find(id);
            if (statusiNaloga == null)
            {
                return NotFound();
            }

            db.StatusiNaloga.Remove(statusiNaloga);
            db.SaveChanges();

            return Ok(statusiNaloga);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StatusiNalogaExists(int id)
        {
            return db.StatusiNaloga.Count(e => e.Id == id) > 0;
        }
    }
}