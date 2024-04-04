using EfDbFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfDbFirst.Forms;
public partial class FrmCreatedSupplier : Form
{
    public FrmCreatedSupplier()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        NorthwndContext db = new NorthwndContext();

        Supplier supplier = new Supplier();
        supplier.CompanyName = txtCompanyName.Text.Trim();
        supplier.ContactName = txtContactName.Text.Trim();
        supplier.ContactTitle = txtContactTitle.Text.Trim();

        db.Suppliers.Add(supplier);
        db.SaveChanges();
        MessageBox.Show("Supplier Added Successfully");
    }
}
