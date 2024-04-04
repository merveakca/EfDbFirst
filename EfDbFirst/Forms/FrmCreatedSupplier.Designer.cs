namespace EfDbFirst.Forms;

partial class FrmCreatedSupplier
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
        txtCompanyName = new TextBox();
        txtContactName = new TextBox();
        label2 = new Label();
        txtContactTitle = new TextBox();
        label3 = new Label();
        btnAdd = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(87, 66);
        label1.Name = "label1";
        label1.Size = new Size(141, 25);
        label1.TabIndex = 0;
        label1.Text = "Company Name";
        // 
        // txtCompanyName
        // 
        txtCompanyName.Location = new Point(257, 60);
        txtCompanyName.Name = "txtCompanyName";
        txtCompanyName.Size = new Size(150, 31);
        txtCompanyName.TabIndex = 1;
        // 
        // txtContactName
        // 
        txtContactName.Location = new Point(257, 131);
        txtContactName.Name = "txtContactName";
        txtContactName.Size = new Size(150, 31);
        txtContactName.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(87, 137);
        label2.Name = "label2";
        label2.Size = new Size(125, 25);
        label2.TabIndex = 2;
        label2.Text = "Contact Name";
        // 
        // txtContactTitle
        // 
        txtContactTitle.Location = new Point(257, 207);
        txtContactTitle.Name = "txtContactTitle";
        txtContactTitle.Size = new Size(150, 31);
        txtContactTitle.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(87, 213);
        label3.Name = "label3";
        label3.Size = new Size(110, 25);
        label3.TabIndex = 4;
        label3.Text = "Contact Title";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(306, 282);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(101, 48);
        btnAdd.TabIndex = 6;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // FrmCreatedSupplier
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(479, 461);
        Controls.Add(btnAdd);
        Controls.Add(txtContactTitle);
        Controls.Add(label3);
        Controls.Add(txtContactName);
        Controls.Add(label2);
        Controls.Add(txtCompanyName);
        Controls.Add(label1);
        Name = "FrmCreatedSupplier";
        Text = "FrmCreatedSupplier";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtCompanyName;
    private TextBox txtContactName;
    private Label label2;
    private TextBox txtContactTitle;
    private Label label3;
    private Button btnAdd;
}