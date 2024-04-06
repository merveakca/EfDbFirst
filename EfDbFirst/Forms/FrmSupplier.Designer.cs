namespace EfDbFirst.Forms;

partial class FrmSupplier
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
        btnDelete = new Button();
        dgwSupplier = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgwSupplier).BeginInit();
        SuspendLayout();
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.IndianRed;
        btnDelete.Location = new Point(96, 74);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(150, 45);
        btnDelete.TabIndex = 3;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // dgwSupplier
        // 
        dgwSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgwSupplier.Location = new Point(96, 141);
        dgwSupplier.Name = "dgwSupplier";
        dgwSupplier.RowHeadersWidth = 62;
        dgwSupplier.Size = new Size(701, 523);
        dgwSupplier.TabIndex = 2;
        // 
        // FrmSupplier
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(925, 723);
        Controls.Add(btnDelete);
        Controls.Add(dgwSupplier);
        Name = "FrmSupplier";
        Text = "FrmSupplier";
        Load += FrmSupplier_Load;
        ((System.ComponentModel.ISupportInitialize)dgwSupplier).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button btnDelete;
    private DataGridView dgwSupplier;
}