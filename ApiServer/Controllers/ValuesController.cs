using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiServer.Calsses;

namespace ApiServer.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] {  "Alabama", "Alaska", "Arizona", "Arkansas", "California",
        //"Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii",
        //"Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana",
        //"Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota",
        //"Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
        //"New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota",
        //"Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island",
        //"South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont",
        //"Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };
        //}

        //[Route("api/Get2")]
        //public IEnumerable<string> Get2()
        //{
        //    return new string[] {  "Alabama", "Alaska", "Arizona", "Arkansas", "California",
        //"Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii",
        //"Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana",
        //"Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota",
        //"Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
        //"New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota",
        //"Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island",
        //"South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont",
        //"Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };
        //}


        [Route("api/GetNations/{Src}")]
        public IEnumerable<string> GetNations(string Src)
        {
           
            string[] arr= new string[] {  "Alabama", "Alaska", "Arizona", "Arkansas", "California",
        "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii",
        "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana",
        "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota",
        "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
        "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota",
        "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island",
        "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont",
        "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming","Roma","Verona" };

            string[] LstFiltered = Array.FindAll(arr, x => x.Contains(Src));
            //List<string> Lst = arr.ToList();
            //List<string> lst2= Lst.Where(fl => fl.Any(x => Lst.Contains(x.ToString()))).ToList();
            return LstFiltered;
        }
        [Route("api/GetNationsWithId/{Src}")]
        public IEnumerable<Nazione> GetNationsWithId(string Src)
        {
            Nazione[] arr = new Nazione[] { new Nazione(1, "Alabama") , new Nazione(2, "Arizona") , new Nazione(3, "Arkansas"), new Nazione(4, "California"), new Nazione(5, "Colorado") };

            List<Nazione> lst = new List<Nazione> { new Nazione(1, "Alabama"), new Nazione(2, "Arizona"), new Nazione(3, "Arkansas"), new Nazione(4, "California"), new Nazione(5, "Colorado") };

            //    string[] arr = new string[] {  "Alabama", "Alaska", "Arizona", "Arkansas", "California",
            //"Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii",
            //"Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana",
            //"Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota",
            //"Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
            //"New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota",
            //"Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island",
            //"South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont",
            //"Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming","Roma","Verona" };

            Nazione[] ArrFiltered = lst.Where(x => x.title.Contains(Src)).ToArray();

            //string[] LstFiltered = Array.FindAll(arr, x => x.Contains(Src));
            //List<string> Lst = arr.ToList();
            //List<string> lst2= Lst.Where(fl => fl.Any(x => Lst.Contains(x.ToString()))).ToList();
            return ArrFiltered;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
