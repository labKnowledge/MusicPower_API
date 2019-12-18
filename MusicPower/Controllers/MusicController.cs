using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MusicPower.Models;


namespace MusicPower.Controllers
{
    public class MusicController : ApiController
    {
        // GET api/values
        public IEnumerable<Artist> Get()
        {
            using (DzalekaArtistEntities  accessor = new DzalekaArtistEntities())
            {
                return accessor.Artists.ToList();
            }
        }

        // GET api/values/5
        public Artist Get(string id)
        {
            using (DzalekaArtistEntities music  = new DzalekaArtistEntities())
            {
                return music.Artists.FirstOrDefault(e => e.ArtistId == id);
            }
        }

        // POST api/values
        public void Post([FromBody]Artist musician)
        {
            using (DzalekaArtistEntities art = new DzalekaArtistEntities())
            {
                //var a = art.Set<music>();
                //a.Add(musician);
                //musician.ID = Guid.NewGuid();
                art.Artists.Add(musician);
                art.SaveChanges();
            }
        }

        // PUT api/values/5
        public void Put(string id, [FromBody]Artist musician)
        {
            using (DzalekaArtistEntities art = new DzalekaArtistEntities())
            {

                Artist m = art.Artists.FirstOrDefault(e => e.ArtistId == id);
                
                art.Artists.Add(musician);
                art.SaveChanges();
            }
        }

        // DELETE api/values/5
        public void Delete(string id)
        {
            using (DzalekaArtistEntities m = new DzalekaArtistEntities())
            {
                m.Artists.Remove(m.Artists.FirstOrDefault(x => x.ArtistId == id));
                m.SaveChanges();
            }
        }
    }
}
