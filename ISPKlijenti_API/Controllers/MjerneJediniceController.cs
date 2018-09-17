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
    public class MjerneJediniceController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/MjerneJedinice
        public IQueryable<MjerneJedinice> GetMjerneJedinice()
        {
            return db.MjerneJedinice;
        }

        // GET: api/MjerneJedinice/5
        [ResponseType(typeof(MjerneJedinice))]
        public IHttpActionResult GetMjerneJedinice(int id)
        {
            MjerneJedinice mjerneJedinice = db.MjerneJedinice.Find(id);
            if (mjerneJedinice == null)
            {
                return NotFound();
            }

            return Ok(mjerneJedinice);
        }

        // PUT: api/MjerneJedinice/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMjerneJedinice(int id, MjerneJedinice mjerneJedinice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mjerneJedinice.Id)
            {
                return BadRequest();
            }

            db.Entry(mjerneJedinice).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MjerneJediniceExists(id))
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

        // POST: api/MjerneJedinice
        [ResponseType(typeof(MjerneJedinice))]
        public IHttpActionResult PostMjerneJedinice(MjerneJedinice mjerneJedinice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MjerneJedinice.Add(mjerneJedinice);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = mjerneJedinice.Id }, mjerneJedinice);
        }

        // DELETE: api/MjerneJedinice/5
        [ResponseType(typeof(MjerneJedinice))]
        public IHttpActionResult DeleteMjerneJedinice(int id)
        {
            MjerneJedinice mjerneJedinice = db.MjerneJedinice.Find(id);
            if (mjerneJedinice == null)
            {
                return NotFound();
            }

            db.MjerneJedinice.Remove(mjerneJedinice);
            db.SaveChanges();

            return Ok(mjerneJedinice);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MjerneJediniceExists(int id)
        {
            return db.MjerneJedinice.Count(e => e.Id == id) > 0;
        }
    }
}