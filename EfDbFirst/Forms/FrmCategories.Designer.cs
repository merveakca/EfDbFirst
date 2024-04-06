namespace EfDbFirst.Forms;

partial class FrmCategories
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
        dgwCategories = new DataGridView();
        btnDelete = new Button();
        label1 = new Label();
        txtName = new TextBox();
        txtDescription = new TextBox();
        label2 = new Label();
        btnUpdate = new Button();
        ((System.ComponentModel.ISupportInitialize)dgwCategories).BeginInit();
        SuspendLayout();
        // 
        // dgwCategories
        // 
        dgwCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgwCategories.Location = new Point(12, 109);
        dgwCategories.Name = "dgwCategories";
        dgwCategories.RowHeadersWidth = 62;
        dgwCategories.Size = new Size(701, 523);
        dgwCategories.TabIndex = 0;
        dgwCategories.CellClick += dgwCategories_CellClick;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.IndianRed;
        btnDelete.Location = new Point(12, 42);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(150, 45);
        btnDelete.TabIndex = 1;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(926, 137);
        label1.Name = "label1";
        label1.Size = new Size(59, 25);
        label1.TabIndex = 2;
        label1.Text = "Name";
        // 
        // txtName
        // 
        txtName.Location = new Point(1051, 131);
        txtName.Name = "txtName";
        txtName.Size = new Size(212, 31);
        txtName.TabIndex = 3;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(1051, 205);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(212, 31);
        txtDescription.TabIndex = 5;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(926, 211);
        label2.Name = "label2";
        label2.Size = new Size(102, 25);
        label2.TabIndex = 4;
        label2.Text = "Description";
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(1151, 275);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(112, 34);
        btnUpdate.TabIndex = 6;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // FrmCategories
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1551, 678);
        Controls.Add(btnUpdate);
        Controls.Add(txtDescription);
        Controls.Add(label2);
        Controls.Add(txtName);
        Controls.Add(label1);
        Controls.Add(btnDelete);
        Controls.Add(dgwCategories);
        Name = "FrmCategories";
        Text = "FrmCategories";
        Load += FrmCategories_Load;
        ((System.ComponentModel.ISupportInitialize)dgwCategories).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dgwCategories;
    private Button btnDelete;
    private Label label1;
    private TextBox txtName;
    private TextBox txtDescription;
    private Label label2;
    private Button btnUpdate;
}