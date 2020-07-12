using Charity.Mvc.Context;
using Charity.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public class InstitutionService
    {
        private readonly EFContext Context;
        public InstitutionService(EFContext context)
        {
            Context = context;
        }
        public List<InstitutionModel> GetAll()
        {
            List<InstitutionModel> institutions = new List<InstitutionModel>();
            try { institutions = Context.Institutions.ToList(); }
            catch (Exception ex) { Console.WriteLine(ex.Message + "\n" + ex.InnerException); }
            return institutions;
        }
        public InstitutionModel GetOne(int institutionId)
        {
            InstitutionModel institution;
            try
            {
                institution = Context.Institutions
                   .Where(x => x.Id == institutionId)
                   .First();
                return institution;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
            return null;
        }
    }
}
