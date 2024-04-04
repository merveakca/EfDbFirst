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
        ((System.ComponentModel.ISupportInitialize)dgwCategories).BeginInit();
        SuspendLayout();
        // 
        // dgwCategories
        // 
        dgwCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgwCategories.Location = new Point(12, 109);
        dgwCategories.Name = "dgwCategories";
        dgwCategories.RowHeadersWidth = 62;
        dgwCategories.Size = new Size(1273, 523);
        dgwCategories.TabIndex = 0;
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
        // FrmCategories
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1297, 658);
        Controls.Add(btnDelete);
        Controls.Add(dgwCategories);
        Name = "FrmCategories";
        Text = "FrmCategories";
        Load += FrmCategories_Load;
        ((System.ComponentModel.ISupportInitialize)dgwCategories).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dgwCategories;
    private Button btnDelete;
}