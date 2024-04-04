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

    //dışarıdan id alan va o id'ye ait kategoriyi silen metot
    public void DeleteCategory(int id)
    {
        NorthwndContext db = new NorthwndContext();
        Category category = db.Categories.FirstOrDefault(x => x.CategoryId == id);

        if (category != null)
        {
            db.Categories.Remove(category);
            db.SaveChanges();
        }
    }

    //dışarıdan id alan va o id'ye ait kategoriyi döndüren metot
    public Category GetCategoryById(int id)
    {
        NorthwndContext db = new NorthwndContext();
        Category category = db.Categories.FirstOrDefault(x => x.CategoryId == id);
        return category;
    }




}
