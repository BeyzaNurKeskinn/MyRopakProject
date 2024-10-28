using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responnseMessage = await client.GetAsync("http://localhost:59253/api/DashboardWidgets/StaffCount");
            if (responnseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responnseMessage.Content.ReadAsStringAsync();
                //   var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                ViewBag.v = jsonData;
            }
            return View();
        }
    }
}