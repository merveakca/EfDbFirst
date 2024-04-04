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
public partial class FrmAddProduct : Form
{
    public FrmAddProduct()
    {
        InitializeComponent();
    }

    private void FrmAddProduct_Load(object sender, EventArgs e)
    {
        NorthwndContext db = new NorthwndContext();
        List<Category> categories = db.Categories.ToList();
        cmbCategory.DataSource = categories;
        cmbCategory.DisplayMember = "CategoryName";
        cmbCategory.ValueMember = "CategoryId";
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        NorthwndContext db = new NorthwndContext();
        Product product = new Product();
        product.ProductName = txtName.Text;
        product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
        product.UnitsInStock = Convert.ToInt16(txtStock.Text);
        product.CategoryId = (int)cmbCategory.SelectedValue;

        db.Products.Add(product);
        db.SaveChanges();
        MessageBox.Show("Product added successfully");
    }
}
