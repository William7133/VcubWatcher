using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using VclubWatcher.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.IO;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VclubWatcher.Controllers
{
  public partial class Api
  {
    public void Page_Load(object sender, EventArgs e)
    {
      string strurltest = string.Format("https://api.alexandredubois.com/vcub-backend/vcub.php");
      WebRequest resquestObject = WebRequest.Create(strurltest);
      requestObjGet.Method = "GET";
      HttpWebResponse responseObjGet = null;
      responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();

      string strresulttest = null;
      using (Stream stream = responseObjGet.GetResponseStream())
      {
        StreamReader sr = new StreamReader(stream);
        strresulttest = sr.ReadToEnd();
        sr.Close();
      }
    }
  }

}


