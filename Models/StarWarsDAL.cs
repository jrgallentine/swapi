using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SWAPI.Models
{
    public class StarWarsDAL
    {
        public string GetData(string category, string id)
        {
            string url = @$"https://swapi.dev/api/{category}/{id}/";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string json = rd.ReadToEnd(); //gets rid of all of the JSON in the back

            return json;
        }
        public Person ConvertToPerson(int id)
        {
            string perData = GetData(id.ToString(), "people");
            Person p = JsonConvert.DeserializeObject<Person>(perData);

            return p;
        }
        public Planet ConvertToPlanet(int id)
        {
            string plaData = GetData(id.ToString(), "planets");
            Planet p = JsonConvert.DeserializeObject<Planet>(plaData);

            return p;
        }

    }
}
