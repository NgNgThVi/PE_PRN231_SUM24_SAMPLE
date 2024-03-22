using Client.Pages.Inheritance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using PE_PRN231_SE160956_SUM24.Models;

namespace Client.Pages.Stars
{
    public class IndexModel : ClientAbstract
    {
        public IndexModel(IHttpClientFactory http, IHttpContextAccessor httpContextAccessor) : base(http, httpContextAccessor)
        {
        }

        public IList<StarModels> Star { get; set; } = default!;
        [BindProperty]
        public string Nationality { get; set; }
        [BindProperty]
        public string Gender { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            var nationality = Request.Query["Nationality"].ToString();
            var gender = Request.Query["Gender"].ToString();
            if (nationality.IsNullOrEmpty() || gender.IsNullOrEmpty())
            {
                Star = new List<StarModels>();
                return Page();
            }
            /*   if (!CheckAuthen())
               {
                   return RedirectToPage("/Login");
               }
            string token = _context.HttpContext.Session.GetString("token");
               HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            */
            HttpResponseMessage response = await HttpClient.GetAsync($"api/star/getstars/{nationality}/{gender}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Star = JsonConvert.DeserializeObject<List<StarModels>>(content);
            }
            return Page();
        }
    }
}
