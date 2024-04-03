namespace EfDbFirst.Forms;

partial class FrmFilterMaxMin
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dtGridProducts = new DataGridView();
        btnFilter = new Button();
        txtMin = new TextBox();
        txtMax = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dtGridProducts).BeginInit();
        SuspendLayout();
        // 
        // dtGridProducts
        // 
        dtGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtGridProducts.Location = new Point(25, 205);
        dtGridProducts.Name = "dtGridProducts";
        dtGridProducts.RowHeadersWidth = 62;
        dtGridProducts.Size = new Size(1175, 519);
        dtGridProducts.TabIndex = 0;
        // 
        // btnFilter
        // 
        btnFilter.Font = new Font("Segoe UI", 20F);
        btnFilter.Location = new Point(702, 98);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new Size(211, 61);
        btnFilter.TabIndex = 1;
        btnFilter.Text = "Filter";
        btnFilter.UseVisualStyleBackColor = true;
        btnFilter.Click += btnFilter_Click;
        // 
        // txtMin
        // 
        txtMin.Font = new Font("Segoe UI", 20F);
        txtMin.Location = new Point(25, 98);
        txtMin.Name = "txtMin";
        txtMin.Size = new Size(260, 61);
        txtMin.TabIndex = 2;
        // 
        // txtMax
        // 
        txtMax.Font = new Font("Segoe UI", 20F);
        txtMax.Location = new Point(370, 98);
        txtMax.Name = "txtMax";
        txtMax.Size = new Size(260, 61);
        txtMax.TabIndex = 3;
        // 
        // FrmFilterMaxMin
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1229, 760);
        Controls.Add(txtMax);
        Controls.Add(txtMin);
        Controls.Add(btnFilter);
        Controls.Add(dtGridProducts);
        Name = "FrmFilterMaxMin";
        Text = "FrmFilterMaxMin";
        ((System.ComponentModel.ISupportInitialize)dtGridProducts).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dtGridProducts;
    private Button btnFilter;
    private TextBox txtMin;
    private TextBox txtMax;
}