using EfDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDbFirst.Services;
public class SupplierService
{
    //get all supplier
    public List<Supplier> GetAllSuppliers()
    {
        NorthwndContext db = new NorthwndContext();
        return db.Suppliers.ToList();
    }

    //delete supplier by id
    public void DeleteSupplier(int id)
    {
        NorthwndContext db = new NorthwndContext();
        Supplier supplier = db.Suppliers.Find(id);
        db.Suppliers.Remove(supplier);
        db.SaveChanges();
    }

    //add supplier
    public Supplier AddSupplier(Supplier supplier)
    {
        NorthwndContext db = new NorthwndContext();

        db.Suppliers.Add(supplier);
        db.SaveChanges();

        return supplier;
    }
}
