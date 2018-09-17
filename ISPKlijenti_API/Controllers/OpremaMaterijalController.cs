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
    public class OpremaMaterijalController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/OpremaMaterijal
        public IQueryable<OpremaMaterijal> GetOpremaMaterijal()
        {
            return db.OpremaMaterijal;
        }


        [HttpGet]
        [ResponseType(typeof(List<isp_Oprema_SelectAll_Result>))]
        [Route("api/OpremaMaterijal/SelectAll")]
        public List<isp_Oprema_SelectAll_Result> SelectAll()
        {
            return db.isp_Oprema_SelectAll().ToList();
        }

        // GET: api/OpremaMaterijal/5
        [ResponseType(typeof(OpremaMaterijal))]
        public IHttpActionResult GetOpremaMaterijal(int id)
        {
            OpremaMaterijal opremaMaterijal = db.OpremaMaterijal.Find(id);
            if (opremaMaterijal == null)
            {
                return NotFound();
            }

            return Ok(opremaMaterijal);
        }

        // PUT: api/OpremaMaterijal/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOpremaMaterijal(int id, OpremaMaterijal opremaMaterijal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != opremaMaterijal.Id)
            {
                return BadRequest();
            }

            db.Entry(opremaMaterijal).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpremaMaterijalExists(id))
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

        // POST: api/OpremaMaterijal
        [ResponseType(typeof(OpremaMaterijal))]
        public IHttpActionResult PostOpremaMaterijal(OpremaMaterijal opremaMaterijal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OpremaMaterijal.Add(opremaMaterijal);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = opremaMaterijal.Id }, opremaMaterijal);
        }

        // DELETE: api/OpremaMaterijal/5
        [ResponseType(typeof(OpremaMaterijal))]
        public IHttpActionResult DeleteOpremaMaterijal(int id)
        {
            OpremaMaterijal opremaMaterijal = db.OpremaMaterijal.Find(id);
            if (opremaMaterijal == null)
            {
                return NotFound();
            }

            db.OpremaMaterijal.Remove(opremaMaterijal);
            db.SaveChanges();

            return Ok(opremaMaterijal);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OpremaMaterijalExists(int id)
        {
            return db.OpremaMaterijal.Count(e => e.Id == id) > 0;
        }
    }
}