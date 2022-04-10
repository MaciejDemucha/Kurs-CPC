using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejDemuchaLab4.Models
{
    public class PhoneViewModel
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="model"></param>
        /// <param name="manufacturer"></param>
        /// <param name="price"></param>
        /// <param name="size"></param>
        /// <param name="photo"></param>
        public PhoneViewModel(string model, string manufacturer, decimal price, double size, string photo)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Size = size;
            this.Photo = photo;
        }
        /// <summary>
        /// Model
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Producent
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// Cena
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Rozmiar ekranu (przekątna w calach)
        /// </summary>
        public double Size { get; set; }
        /// <summary>
        /// Zdjęcie
        /// </summary>
        public string Photo { get; set; }
    }
}
