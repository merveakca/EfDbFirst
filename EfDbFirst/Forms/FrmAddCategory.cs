using EfDbFirst.Models;
using EfDbFirst.Services;
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
public partial class FrmAddCategory : Form
{
    public FrmAddCategory()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        Category category = new Category();
        category.CategoryName = txtName.Text;
        category.Description = txtDescription.Text;

        CategoryService categoryService = new CategoryService();
        categoryService.AddCategory(category);



    }
}
