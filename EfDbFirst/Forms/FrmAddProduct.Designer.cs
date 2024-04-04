namespace EfDbFirst.Forms;

partial class FrmAddProduct
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
        label1 = new Label();
        cmbCategory = new ComboBox();
        label2 = new Label();
        txtName = new TextBox();
        txtStock = new TextBox();
        label3 = new Label();
        txtUnitPrice = new TextBox();
        label4 = new Label();
        btnAdd = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(93, 66);
        label1.Name = "label1";
        label1.Size = new Size(100, 25);
        label1.TabIndex = 0;
        label1.Text = "Categories:";
        // 
        // cmbCategory
        // 
        cmbCategory.FormattingEnabled = true;
        cmbCategory.Location = new Point(264, 58);
        cmbCategory.Name = "cmbCategory";
        cmbCategory.Size = new Size(182, 33);
        cmbCategory.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(93, 128);
        label2.Name = "label2";
        label2.Size = new Size(63, 25);
        label2.TabIndex = 2;
        label2.Text = "Name:";
        // 
        // txtName
        // 
        txtName.Location = new Point(264, 122);
        txtName.Name = "txtName";
        txtName.Size = new Size(182, 31);
        txtName.TabIndex = 3;
        // 
        // txtStock
        // 
        txtStock.Location = new Point(264, 202);
        txtStock.Name = "txtStock";
        txtStock.Size = new Size(182, 31);
        txtStock.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(93, 208);
        label3.Name = "label3";
        label3.Size = new Size(59, 25);
        label3.TabIndex = 4;
        label3.Text = "Stock:";
        // 
        // txtUnitPrice
        // 
        txtUnitPrice.Location = new Point(264, 274);
        txtUnitPrice.Name = "txtUnitPrice";
        txtUnitPrice.Size = new Size(182, 31);
        txtUnitPrice.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(93, 280);
        label4.Name = "label4";
        label4.Size = new Size(90, 25);
        label4.TabIndex = 6;
        label4.Text = "Unit Price:";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(334, 354);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(112, 34);
        btnAdd.TabIndex = 8;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // FrmAddProduct
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(842, 552);
        Controls.Add(btnAdd);
        Controls.Add(txtUnitPrice);
        Controls.Add(label4);
        Controls.Add(txtStock);
        Controls.Add(label3);
        Controls.Add(txtName);
        Controls.Add(label2);
        Controls.Add(cmbCategory);
        Controls.Add(label1);
        Name = "FrmAddProduct";
        Text = "FrmAddProduct";
        Load += FrmAddProduct_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private ComboBox cmbCategory;
    private Label label2;
    private TextBox txtName;
    private TextBox txtStock;
    private Label label3;
    private TextBox txtUnitPrice;
    private Label label4;
    private Button btnAdd;
}