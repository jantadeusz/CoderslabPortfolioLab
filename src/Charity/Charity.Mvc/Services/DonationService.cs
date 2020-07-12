using Charity.Mvc.Context;
using Charity.Mvc.Models;
using Charity.Mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public class DonationService
    {
        private readonly EFContext Context;
        public DonationService(EFContext _context)
        {
            Context = _context;
        }
        public DonationModel Add(DonationViewModel donationView)
        {
            DonationModel donation = null;
            var institutionService = new InstitutionService(Context);
            var categoryService = new CategoryService(Context);
            try
            {
                List<CategoryModel> categories = new List<CategoryModel>();
                foreach (string id in donationView.CategoriesIds)
                {
                    if (id != "false")
                    {
                        categories.Add(categoryService.GetOne(Int32.Parse(id)));
                    }
                }
                donation = new DonationModel()
                {
                    Quantity = donationView.Quantity,
                    Institution = institutionService.GetOne(donationView.InstitutionId),
                    Categories = categories,
                    Street = donationView.Street,
                    City = donationView.City,
                    ZipCode = donationView.ZipCode,
                    PickUpTime = donationView.PickUpTime,
                    PickUpComment = donationView.PickUpComment,
                    Phone = donationView.Phone
                };
                Context.Donations.Add(donation);
                Context.SaveChanges();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message + "\n" + ex.InnerException); }
            return donation;
        }
    }
}
