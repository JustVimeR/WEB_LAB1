using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WEB_LAB1.Models;

namespace WEB_LAB1.Controllers
{
    public class CurrencyRateController : Controller
    {
        private async Task<List<CurrencyRate>> GetCurrencyRates()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5");
            var rates = JsonSerializer.Deserialize<List<CurrencyRate>>(response);
            return rates;
        }

        // GET: CurrencyRateController
        public async Task<IActionResult> Index()
        {
            var rates = await GetCurrencyRates();
            return View(rates);
        }

        // GET: CurrencyRateController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CurrencyRateController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CurrencyRateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CurrencyRateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CurrencyRateController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CurrencyRateController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CurrencyRateController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
