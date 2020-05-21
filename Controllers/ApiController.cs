using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using BikeWatcher.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BikeWatcher.Controllers
{
  public class ApiController : Controller
  {
    // GET: /<controller>/
    public IActionResult Index()
    {
      return View();
    }

    private static readonly HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
      await ProcessRepositories();
    }
    public static async Task<List<BikeStation>> ProcessRepositories()
    {
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(
          new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
      client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

      var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
      var DataBrute = await JsonSerializer.DeserializeAsync<Root>(await streamTask);
      var Data = DataBrute.values;
      return Data;
    }



  }

}
