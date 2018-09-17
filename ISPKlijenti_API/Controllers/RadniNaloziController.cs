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
    public class RadniNaloziController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/RadniNalozi
        public IQueryable<RadniNalozi> GetRadniNalozi()
        {
            return db.RadniNalozi;
        }

        [HttpGet]
        [ResponseType(typeof(List<isp_RadniNalozi_SelectByKlijent_Result>))]
        [Route("api/RadniNalozi/GetRadniNaloziIndex/{klijent?}")]
        public IHttpActionResult GetRadniNaloziIndex(string klijent = "")
        {
            return Ok(db.isp_RadniNalozi_Index(klijent).ToList());
        }

        // GET: api/RadniNalozi/5
        [ResponseType(typeof(RadniNalozi))]
        public IHttpActionResult GetRadniNalozi(int id)
        {
            RadniNalozi radniNalozi = db.RadniNalozi.Find(id);
            if (radniNalozi == null)
            {
                return NotFound();
            }

            return Ok(radniNalozi);
        }

        // PUT: api/RadniNalozi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRadniNalozi(int id, RadniNalozi radniNalozi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != radniNalozi.Id)
            {
                return BadRequest();
            }

            db.Entry(radniNalozi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RadniNaloziExists(id))
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

        // POST: api/RadniNalozi
        [ResponseType(typeof(RadniNalozi))]
        public IHttpActionResult PostRadniNalozi(RadniNalozi radniNalozi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RadniNalozi.Add(radniNalozi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = radniNalozi.Id }, radniNalozi);
        }

        // DELETE: api/RadniNalozi/5
        [ResponseType(typeof(RadniNalozi))]
        public IHttpActionResult DeleteRadniNalozi(int id)
        {
            RadniNalozi radniNalozi = db.RadniNalozi.Find(id);
            if (radniNalozi == null)
            {
                return NotFound();
            }

            db.RadniNalozi.Remove(radniNalozi);
            db.SaveChanges();

            return Ok(radniNalozi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RadniNaloziExists(int id)
        {
            return db.RadniNalozi.Count(e => e.Id == id) > 0;
        }
    }
}