using Charity.Mvc.Context;
using Charity.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public class CategoryService
    {

        private readonly EFContext Context;
        public CategoryService(EFContext context)
        {
            Context = context;
        }
        public List<CategoryModel> GetAll()
        {
            List<CategoryModel> categories = new List<CategoryModel>();
            try { categories = Context.Categories.ToList(); }
            catch (Exception ex) { Console.WriteLine(ex.Message + "\n" + ex.InnerException); }
            return categories;
        }
        public CategoryModel GetOne(int categoryId)
        {
            CategoryModel category;
            try
            {
                category = Context.Categories
                   .Where(x => x.Id == categoryId)
                   .First();
                return category;
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
