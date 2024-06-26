﻿using EfDbFirst.Models;
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
public partial class FrmCategories : Form
{
    public FrmCategories()
    {
        InitializeComponent();
    }

    private void FrmCategories_Load(object sender, EventArgs e)
    {
        CategoryService categoryService = new CategoryService();
        dgwCategories.DataSource = categoryService.GetAllCategories();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            int selectedCategoryId = (int)dgwCategories.CurrentRow.Cells[0].Value;

            CategoryService categoryService = new CategoryService();
            categoryService.DeleteCategory(selectedCategoryId);
            dgwCategories.DataSource = categoryService.GetAllCategories();
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
    }

    private void dgwCategories_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        int selectedCategoryId = (int)dgwCategories.CurrentRow.Cells[0].Value;

        CategoryService categoryService = new CategoryService();
        Category category = categoryService.GetCategoryById(selectedCategoryId);

        txtName.Text = category.CategoryName;
        txtDescription.Text = category.Description;
    }
}
