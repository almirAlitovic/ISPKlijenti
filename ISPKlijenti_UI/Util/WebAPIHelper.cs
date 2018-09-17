using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ISPKlijenti_UI.Util
{
    public class WebAPIHelper
    {
        private HttpClient client { get; set; }
        private string route { get; set; }

        public WebAPIHelper(string uri, string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.route = route;
        }

        public HttpResponseMessage GetResponse()
        {
            return client.GetAsync(route).Result;
        }

        public HttpResponseMessage GetResponse(string parametar)
        {
            //api/Zaposlenici/{id}
            return client.GetAsync(route + "/" + parametar).Result;
        }

        public HttpResponseMessage PostResponse(Object newObject)
        {
            return client.PostAsJsonAsync(route, newObject).Result;
        }

        public HttpResponseMessage getActionResponse(string action, string parameter = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parameter).Result;
        }

        public HttpResponseMessage getActionResponse2(string action, string parameter1 = "", string parameter2 = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parameter1 + "/" + parameter2).Result;
        }

        public HttpResponseMessage PutResponse(int id, Object existingObject)
        {
            return client.PutAsJsonAsync(route + "/" + id, existingObject).Result;
        }

    }
}
