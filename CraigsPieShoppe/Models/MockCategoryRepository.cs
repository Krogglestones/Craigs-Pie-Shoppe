using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraigsPieShoppe.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit Pies", Description="Fresh fruit in a pie."},
                new Category{CategoryId=2, CategoryName="Cheese Cakes", Description="Cheesy goodness."},
                new Category{CategoryId=3, CategoryName="Seasonal Pies", Description="Pies of the season."}
            };
    }
}
