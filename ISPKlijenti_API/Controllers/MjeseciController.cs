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
    public class MjeseciController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/Mjeseci
        public IQueryable<Mjeseci> GetMjeseci()
        {
            return db.Mjeseci;
        }

        // GET: api/Mjeseci/5
        [ResponseType(typeof(Mjeseci))]
        public IHttpActionResult GetMjeseci(int id)
        {
            Mjeseci mjeseci = db.Mjeseci.Find(id);
            if (mjeseci == null)
            {
                return NotFound();
            }

            return Ok(mjeseci);
        }

        // PUT: api/Mjeseci/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMjeseci(int id, Mjeseci mjeseci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mjeseci.Id)
            {
                return BadRequest();
            }

            db.Entry(mjeseci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MjeseciExists(id))
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

        // POST: api/Mjeseci
        [ResponseType(typeof(Mjeseci))]
        public IHttpActionResult PostMjeseci(Mjeseci mjeseci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Mjeseci.Add(mjeseci);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = mjeseci.Id }, mjeseci);
        }

        // DELETE: api/Mjeseci/5
        [ResponseType(typeof(Mjeseci))]
        public IHttpActionResult DeleteMjeseci(int id)
        {
            Mjeseci mjeseci = db.Mjeseci.Find(id);
            if (mjeseci == null)
            {
                return NotFound();
            }

            db.Mjeseci.Remove(mjeseci);
            db.SaveChanges();

            return Ok(mjeseci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MjeseciExists(int id)
        {
            return db.Mjeseci.Count(e => e.Id == id) > 0;
        }
    }
}