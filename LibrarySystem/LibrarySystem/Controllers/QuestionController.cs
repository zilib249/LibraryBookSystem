using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Diagnostics;

namespace LibrarySystem.Controllers
{
    public class QuestionController : Controller
    {
        static HttpClient client = new HttpClient();

        public async Task<ActionResult> Details(int id)
        { 
            return View();
        }
        // GET: Question
        public async Task<ActionResult> Index()
        {
            return View();
        }

    }
}