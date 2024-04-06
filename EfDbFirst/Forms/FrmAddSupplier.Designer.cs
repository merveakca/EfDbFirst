namespace EfDbFirst.Forms;

partial class FrmAddSupplier
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
        btnAdd = new Button();
        txtContactName = new TextBox();
        label2 = new Label();
        label1 = new Label();
        txtCampanyName = new TextBox();
        SuspendLayout();
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(305, 220);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(112, 34);
        btnAdd.TabIndex = 17;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // txtContactName
        // 
        txtContactName.Location = new Point(245, 137);
        txtContactName.Name = "txtContactName";
        txtContactName.Size = new Size(182, 31);
        txtContactName.TabIndex = 12;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(74, 143);
        label2.Name = "label2";
        label2.Size = new Size(125, 25);
        label2.TabIndex = 11;
        label2.Text = "Contact Name";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(74, 81);
        label1.Name = "label1";
        label1.Size = new Size(139, 25);
        label1.TabIndex = 9;
        label1.Text = "Campany Name";
        // 
        // txtCampanyName
        // 
        txtCampanyName.Location = new Point(245, 75);
        txtCampanyName.Name = "txtCampanyName";
        txtCampanyName.Size = new Size(182, 31);
        txtCampanyName.TabIndex = 18;
        // 
        // FrmAddSupplier
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(486, 317);
        Controls.Add(txtCampanyName);
        Controls.Add(btnAdd);
        Controls.Add(txtContactName);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "FrmAddSupplier";
        Text = "FrmAddSupplier";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnAdd;
    private TextBox txtContactName;
    private Label label2;
    private Label label1;
    private TextBox txtCampanyName;
}