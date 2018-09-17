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
    public class KlijentiLogController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/KlijentiLog
        public IQueryable<KlijentiLog> GetKlijentiLog()
        {
            return db.KlijentiLog;
        }

        // GET: api/KlijentiLog/5
        [ResponseType(typeof(KlijentiLog))]
        public IHttpActionResult GetKlijentiLog(int id)
        {
            KlijentiLog klijentiLog = db.KlijentiLog.Find(id);
            if (klijentiLog == null)
            {
                return NotFound();
            }

            return Ok(klijentiLog);
        }

        // PUT: api/KlijentiLog/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKlijentiLog(int id, KlijentiLog klijentiLog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != klijentiLog.Id)
            {
                return BadRequest();
            }

            db.Entry(klijentiLog).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KlijentiLogExists(id))
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

        // POST: api/KlijentiLog
        [ResponseType(typeof(KlijentiLog))]
        public IHttpActionResult PostKlijentiLog(KlijentiLog klijentiLog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.KlijentiLog.Add(klijentiLog);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = klijentiLog.Id }, klijentiLog);
        }

        // DELETE: api/KlijentiLog/5
        [ResponseType(typeof(KlijentiLog))]
        public IHttpActionResult DeleteKlijentiLog(int id)
        {
            KlijentiLog klijentiLog = db.KlijentiLog.Find(id);
            if (klijentiLog == null)
            {
                return NotFound();
            }

            db.KlijentiLog.Remove(klijentiLog);
            db.SaveChanges();

            return Ok(klijentiLog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KlijentiLogExists(int id)
        {
            return db.KlijentiLog.Count(e => e.Id == id) > 0;
        }
    }
}