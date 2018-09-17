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
    public class PosebniRacuniController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/PosebniRacuni
        public IQueryable<PosebniRacuni> GetPosebniRacuni()
        {
            return db.PosebniRacuni;
        }

        [HttpGet]
        [ResponseType(typeof(List<isp_PosebniRacuni_SelectAll_Result>))]
        [Route("api/PosebniRacuni/GetPosebniRacuniIndex/")]
        public IHttpActionResult GetPosebniRacuniIndex()
        {
            List<isp_PosebniRacuni_SelectAll_Result> racuni = db.isp_PosebniRacuni_SelectAll().ToList();
            if (racuni == null)
            {
                return NotFound();
            }
            else
                return Ok(racuni);
        }

        [HttpGet]
        [ResponseType(typeof(isp_PosebniRacuni_SelectById_Result))]
        [Route("api/PosebniRacuni/GetPosebniRacuniById/{id}")]
        public IHttpActionResult GetPosebniRacuniIndex(int id)
        {
            isp_PosebniRacuni_SelectById_Result racun = db.isp_PosebniRacuni_SelectById(id).SingleOrDefault();
            if (racun == null)
            {
                return NotFound();
            }
            else
                return Ok(racun);
        }

        // GET: api/PosebniRacuni/5
        [ResponseType(typeof(PosebniRacuni))]
        public IHttpActionResult GetPosebniRacuni(int id)
        {
            PosebniRacuni posebniRacuni = db.PosebniRacuni.Find(id);
            if (posebniRacuni == null)
            {
                return NotFound();
            }

            return Ok(posebniRacuni);
        }

        // PUT: api/PosebniRacuni/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPosebniRacuni(int id, PosebniRacuni posebniRacuni)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != posebniRacuni.Id)
            {
                return BadRequest();
            }

            db.Entry(posebniRacuni).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PosebniRacuniExists(id))
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

        // POST: api/PosebniRacuni
        [ResponseType(typeof(PosebniRacuni))]
        public IHttpActionResult PostPosebniRacuni(PosebniRacuni posebniRacuni)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PosebniRacuni.Add(posebniRacuni);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = posebniRacuni.Id }, posebniRacuni);
        }

        // DELETE: api/PosebniRacuni/5
        [ResponseType(typeof(PosebniRacuni))]
        public IHttpActionResult DeletePosebniRacuni(int id)
        {
            PosebniRacuni posebniRacuni = db.PosebniRacuni.Find(id);
            if (posebniRacuni == null)
            {
                return NotFound();
            }

            db.PosebniRacuni.Remove(posebniRacuni);
            db.SaveChanges();

            return Ok(posebniRacuni);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PosebniRacuniExists(int id)
        {
            return db.PosebniRacuni.Count(e => e.Id == id) > 0;
        }
    }
}