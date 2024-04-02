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
public partial class FrmFilterMaxMin : Form
{
    public FrmFilterMaxMin()
    {
        InitializeComponent();
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
        int max = Convert.ToInt32(txtMax.Text);
        int min = Convert.ToInt32(txtMin.Text);

        NorthwndContext db = new NorthwndContext();
        List<Product> products = db.Products.Where(x => x.UnitPrice > min && x.UnitPrice < max).OrderBy(x => x.UnitPrice).ToList();
    }
}
