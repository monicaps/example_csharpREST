using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyWebServiceREST.Models;
using MyWebServiceREST.Services.Interfaces;

namespace MyWebServiceREST.Services
{
    public class HelloWorldServices:IHelloWorldServices
    {
        private readonly IConfiguration _config;

        public HelloWorldServices(IConfiguration config)
        {
            _config = config;
        }

        public int GetIDDocument()
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(_config.GetConnectionString("MemoramaConnection")))
            {
                string query = @"SELECT distinct top 1 (idDocumento) FROM documento ORDER BY idDocumento DESC";
                dynamic id = conn.Query<int>(query).AsQueryable().FirstOrDefault();
                return id;
            }
        }

        public string GetMessage()
        {
            return "Hello World Programmer.!!";
        }
    }
}
