using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {

        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit pies",Description="All-fruit pies"},
                new Category{CategoryId=2, CategoryName="cheese cakes",Description="cheesy all the way"},
                new Category{CategoryId=3, CategoryName="Seasonal Pies",Description="get in the mood fora seasonal pie"}
            };
        public Category GetPieById(int id)
        {
            return AllCategories.FirstOrDefault(el => el.CategoryId == id);
        }

    }
}
