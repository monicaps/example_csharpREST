using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MyWebServiceREST.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MyWebServiceREST.Services.Interfaces
{
    public interface IHelloWorldServices
    {
        string GetMessage();
        int GetIDDocument();
    }
}
