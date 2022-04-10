using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejDemuchaLab4.Models
{
    public class ContactFormViewModel : Controller
    {

        public ContactFormViewModel(String FirstName, String LasttName, String Description)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Description = Description;
        }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Description { get; set; }
        
    }
}
