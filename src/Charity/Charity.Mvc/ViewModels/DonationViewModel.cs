using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.ViewModels
{
    public class DonationViewModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public List<string> CategoriesIds { get; set; }
        public int InstitutionId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public DateTime PickUpTime { get; set; }
        public string PickUpComment { get; set; }
        public string Phone { get; set; }
    }
}
