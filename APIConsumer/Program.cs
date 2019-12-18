using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APIConsumer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var http = new HttpClient();
             Artist m = new Artist();
            m.ArtistId = Guid.NewGuid().ToString();
            m.ArtistBio = "Bra bra";
            m.ArtistGenre = "RnB";
            m.ArtistName = "Kiza Kashindi";

            var d = JsonConvert.SerializeObject(m);
            HttpContent content = new StringContent(d,Encoding.UTF8,"application/json");
            var t = http.PostAsync("http://localhost:55106/api/Music", content).Result;

        }
    }
}
