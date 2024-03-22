using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BussinessObject.Models;
using Client.Pages.Inheritance;
using PE_PRN231_SE160956_SUM24.Models;
using Newtonsoft.Json;

namespace Client.Pages.Stars
{
    public class DetailsModel : ClientAbstract
    {
        public DetailsModel(IHttpClientFactory http, IHttpContextAccessor httpContextAccessor) : base(http, httpContextAccessor)
        {
        }

        public StartModelIncludeMovie Star { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id == null)
            {
                return RedirectToPage("/Stars/Index");
            }
            /*   if (!CheckAuthen())
   {
       return RedirectToPage("/Login");
   }
string token = _context.HttpContext.Session.GetString("token");
   HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
*/
            HttpResponseMessage response = await HttpClient.GetAsync($"api/star/getstars/{id}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Star = JsonConvert.DeserializeObject<StartModelIncludeMovie>(content);
            }
            return Page();
        }
    }
}
