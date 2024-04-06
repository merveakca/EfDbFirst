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
public partial class FrmSupplier : Form
{
    public FrmSupplier()
    {
        InitializeComponent();
    }

    private void FrmSupplier_Load(object sender, EventArgs e)
    {
        SupplierService supplierService = new SupplierService();
        dgwSupplier.DataSource = supplierService.GetAllSuppliers();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            int id = Convert.ToInt32(dgwSupplier.CurrentRow.Cells[0].Value);
            SupplierService supplierService = new SupplierService();
            supplierService.DeleteSupplier(id);
            dgwSupplier.DataSource = supplierService.GetAllSuppliers();
        }
        catch (Exception)
        {
            MessageBox.Show("Supplier silme işlemi sırasında bir hata meydana geldi");
        }
    }
}
