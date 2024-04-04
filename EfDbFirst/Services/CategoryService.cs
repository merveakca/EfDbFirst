using EfDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDbFirst.Services;
public class CategoryService
{
    public void AddCategory(Category category)
    {
        NorthwndContext db = new NorthwndContext();
        db.Categories.Add(category);
        db.SaveChanges();
    }

    public List<Category> GetAllCategories()
    {
        NorthwndContext db = new NorthwndContext();
        List<Category> categories = db.Categories.OrderBy(q => q.CategoryName).ToList();
        return categories;

    }
}
