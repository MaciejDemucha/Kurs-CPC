using MaciejDemuchaLab4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejDemuchaLab4.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Lista telefonów do wyświetlenia
        /// </summary>
        List<PhoneViewModel> allPhones;
        /// <summary>
        /// Lista telefonów przy wyświetlaniu wg producenta
        /// </summary>
        List<PhoneViewModel> PhonesByManufacturer;
        /// <summary>
        /// Lista telefonów przy wyświetlaniu wg ceny
        /// </summary>
        List<PhoneViewModel> PhonesByPrice;

        /// <summary>
        /// Konstruktor z parametrem
        /// </summary>
        /// <param name="context"></param>
        public HomeController()
        {
            this.allPhones = new List<PhoneViewModel>();
            allPhones.Add(new PhoneViewModel("iPhone 13", "Apple", 4400, 6.1, "~/iphone13.jpg"));
            allPhones.Add(new PhoneViewModel("Galaxy S21", "Samsung", 3600, 6.2, "~/s21.png"));
            allPhones.Add(new PhoneViewModel("Galaxy A32", "Samsung", 1100, 6.4, "~/a32.jpg"));
            allPhones.Add(new PhoneViewModel("Xperia 5", "Sony", 2500, 6.1, "~/xperia5.png"));
        }

        /// <summary>
        /// Strona główna
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Widok z ciekawymi linkami
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SearchByPrice()
        {
            return View();
        }

        /// <summary>
        /// Lista wszystkich telefonów
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllPhones()
        {
            return View(this.allPhones);
        }

        /// <summary>
        /// Wyświetlenie listy producentów
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetSetOfManufacturers()
        {
            // Lista nazw producentów do wyświetlenia
            HashSet<string> allManufacturers = new HashSet<string>();

            // Pętla dodająca producenta do listy
            foreach (PhoneViewModel phone in this.allPhones)
            {
                allManufacturers.Add(phone.Manufacturer);
            }
            // Przekazanie listy modeli do widoku
            return View(allManufacturers);
        }
        /// <summary>
        /// Wyświetlenie listy modeli
        /// </summary>
        /// <returns></returns>
        public IActionResult GetListOfModels()
        {
            // Lista nazw producentów do wyświetlenia
            List<string> allModels = new List<string>();

            // Pętla dodająca producenta do listy
            foreach (PhoneViewModel phone in this.allPhones)
            {
                allModels.Add(phone.Model);
            }
            // Przekazanie listy modeli do widoku
            return View(allModels);
        }

        /// <summary>
        /// Pobranie telefonów po jego producencie
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetPhoneByManufacturer(string model)
        {
            
            this.PhonesByManufacturer =  this.allPhones.Where(a => a.Manufacturer.ToLower() == model.ToLower()).ToList();

            // Przekazanie listy do widoku
            return View(this.PhonesByManufacturer);
        }

        /// <summary>
        /// Pobranie telefonu po jego modelu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetPhoneByModel(string model)
        {

            PhoneViewModel phone = this.allPhones.Where(a => a.Model.ToLower() == model.ToLower()).FirstOrDefault();

            // Przekazanie obiektu do widoku
            return View(phone);
        }

        [HttpGet]
        public IActionResult GetPhoneByPrice(string model)
        {

            this.PhonesByPrice = this.allPhones.Where(a => a.Price >= ViewBag.Min && a.Price <= ViewBag.Max).ToList();

            // Przekazanie listy do widoku
            return View(this.PhonesByPrice);
        }

        /// <summary>
        /// Wyświetlenie formularza wyboru przedziału ceny
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SetPrice()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetPrice(SearchByPriceViewModel userData)
        {
            string Min = userData.Min;
            string Max = userData.Max;
            ViewBag.Min = Min;
            ViewBag.Max = Max;
            return View("GetPhoneByPrice");
        }

        /// <summary>
        /// Wyświetlenie formularza kontaktowego do wypełnienia
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }

        /// <summary>
        /// Wyświetlenie powitania po wypełnieniu formularza kontaktowego
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            ViewBag.UserName = fullName;
            return View("ContactFormGreetings");
        }

        /// <summary>
        /// Wyświetlenie informacji o błędzie
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
