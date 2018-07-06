using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebFrontEnd.Pages
{
    public class IndexModel : PageModel
    {
        public Model.ToDoItem[] Items = new Model.ToDoItem[] { };

        public void OnGet()
        {
            HttpClient client = new HttpClient();

            using (HttpResponseMessage response = client.GetAsync(backendUrl).GetAwaiter().GetResult())
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Items = Newtonsoft.Json.JsonConvert.DeserializeObject<Model.ToDoItem[]>(response.Content.ReadAsStringAsync().Result);
                }
            }
        }

        private static string backendDNSName = $"{Environment.GetEnvironmentVariable("ServiceName")}.{Environment.GetEnvironmentVariable("AppName")}";
        private static Uri backendUrl = new Uri($"http://{backendDNSName}:{Environment.GetEnvironmentVariable("ApiHostPort")}/api/todo");
    }
}
