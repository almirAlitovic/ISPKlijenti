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
    public class RacuniController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/Racuni
        public IQueryable<Racuni> GetRacuni()
        {
            return db.Racuni;
        }

        [HttpGet]
        [ResponseType(typeof(List<isp_Racuni_SelectByKlijent_Result>))]
        [Route("api/Racuni/GetRacunByKlijent/{klijent?}")]
        public IHttpActionResult GetRacunByKlijent(string klijent = "")
        {
            List<isp_Racuni_SelectByKlijent_Result> racuni = db.isp_Racuni_SelectByKlijent(klijent).ToList();
            if (racuni == null)
            {
                return NotFound();
            }
            else
                return Ok(racuni);
        }

        [HttpGet]
        [ResponseType(typeof(isp_Racuni_SelectById_Result))]
        [Route("api/Racuni/GetRacunById/{id}")]
        public IHttpActionResult GetRacunByKlijent(int id)
        {
            isp_Racuni_SelectById_Result racun = db.isp_Racuni_SelectById(id).SingleOrDefault();
            if (racun == null)
            {
                return NotFound();
            }
            else
                return Ok(racun);
        }


        // GET: api/Racuni/5
        [ResponseType(typeof(Racuni))]
        public IHttpActionResult GetRacuni(int id)
        {
            Racuni racuni = db.Racuni.Find(id);
            if (racuni == null)
            {
                return NotFound();
            }

            return Ok(racuni);
        }

        // PUT: api/Racuni/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRacuni(int id, Racuni racuni)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != racuni.Id)
            {
                return BadRequest();
            }

            db.Entry(racuni).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RacuniExists(id))
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

        // POST: api/Racuni
        [ResponseType(typeof(Racuni))]
        public IHttpActionResult PostRacuni(Racuni racuni)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Racuni.Add(racuni);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = racuni.Id }, racuni);
        }

        // DELETE: api/Racuni/5
        [ResponseType(typeof(Racuni))]
        public IHttpActionResult DeleteRacuni(int id)
        {
            Racuni racuni = db.Racuni.Find(id);
            if (racuni == null)
            {
                return NotFound();
            }

            db.Racuni.Remove(racuni);
            db.SaveChanges();

            return Ok(racuni);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RacuniExists(int id)
        {
            return db.Racuni.Count(e => e.Id == id) > 0;
        }
    }
}