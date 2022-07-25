using Calculator1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Calculator1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        public void AddHistory(DataHistory dh)
        {
            try
            {
                int data = dh.History;
                string query = @"INSERT INTO HistoryTable (history int) VALUES ('" + data + "')";
                String connectString = "Server=DESKTOP-1F0F14FSQLEXPRESS;Database=CarsAndEmployees;User Id=saurabh;Password=Sa@98019;";
                SqlConnection con = new SqlConnection(connectString);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int I = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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

