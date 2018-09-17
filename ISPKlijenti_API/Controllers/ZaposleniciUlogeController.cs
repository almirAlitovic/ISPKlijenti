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
    public class ZaposleniciUlogeController : ApiController
    {
        private IspKlijentiEntities db = new IspKlijentiEntities();

        // GET: api/ZaposleniciUloge
        public IQueryable<ZaposleniciUloge> GetZaposleniciUloge()
        {
            return db.ZaposleniciUloge;
        }

        // GET: api/ZaposleniciUloge/5
        [ResponseType(typeof(ZaposleniciUloge))]
        public IHttpActionResult GetZaposleniciUloge(int id)
        {
            ZaposleniciUloge zaposleniciUloge = db.ZaposleniciUloge.Find(id);
            if (zaposleniciUloge == null)
            {
                return NotFound();
            }

            return Ok(zaposleniciUloge);
        }

        //GetUlogeByZaposlenikId
        [ResponseType(typeof(List<Uloge>))]
        [Route("api/ZaposleniciUloge/GetUlogeByZaposlenikId/{zaposlenikId}")]
        public IHttpActionResult GetUlogeByZaposlenikId(int zaposlenikId)
        {
            List<Uloge> uloge = db.ZaposleniciUloge.Where(u => u.ZaposlenikId == zaposlenikId).Select(x =>x.Uloge).ToList();

            if (uloge == null)
            {
                return NotFound();
            }

            return Ok(uloge);
        }

        [ResponseType(typeof(List<Zaposlenici>))]
        [Route("api/ZaposleniciUloge/GetZaposlenikByUlogaId/{ulogaId}")]
        public IHttpActionResult GetZaposlenikByUlogaId(int ulogaId)
        {
            List<Zaposlenici> tehnicari = db.ZaposleniciUloge.Where(u => u.UlogaId == ulogaId).Select(x => x.Zaposlenici).ToList();

            if (tehnicari == null)
            {
                return NotFound();
            }

            return Ok(tehnicari);
        }

        // PUT: api/ZaposleniciUloge/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutZaposleniciUloge(int id, ZaposleniciUloge zaposleniciUloge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != zaposleniciUloge.Id)
            {
                return BadRequest();
            }

            db.Entry(zaposleniciUloge).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZaposleniciUlogeExists(id))
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

        // POST: api/ZaposleniciUloge
        [ResponseType(typeof(ZaposleniciUloge))]
        public IHttpActionResult PostZaposleniciUloge(ZaposleniciUloge zaposleniciUloge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ZaposleniciUloge.Add(zaposleniciUloge);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = zaposleniciUloge.Id }, zaposleniciUloge);
        }

        // DELETE: api/ZaposleniciUloge/5
        [ResponseType(typeof(ZaposleniciUloge))]
        public IHttpActionResult DeleteZaposleniciUloge(int id)
        {
            ZaposleniciUloge zaposleniciUloge = db.ZaposleniciUloge.Find(id);
            if (zaposleniciUloge == null)
            {
                return NotFound();
            }

            db.ZaposleniciUloge.Remove(zaposleniciUloge);
            db.SaveChanges();

            return Ok(zaposleniciUloge);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ZaposleniciUlogeExists(int id)
        {
            return db.ZaposleniciUloge.Count(e => e.Id == id) > 0;
        }
    }
}