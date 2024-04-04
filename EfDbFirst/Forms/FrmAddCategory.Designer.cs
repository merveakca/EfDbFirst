namespace EfDbFirst.Forms;

partial class FrmAddCategory
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
        txtName = new TextBox();
        txtDescription = new TextBox();
        label2 = new Label();
        btnAdd = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(64, 73);
        label1.Name = "label1";
        label1.Size = new Size(59, 25);
        label1.TabIndex = 0;
        label1.Text = "Name";
        // 
        // txtName
        // 
        txtName.Location = new Point(190, 67);
        txtName.Name = "txtName";
        txtName.Size = new Size(278, 31);
        txtName.TabIndex = 1;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(190, 155);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(278, 31);
        txtDescription.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(64, 161);
        label2.Name = "label2";
        label2.Size = new Size(102, 25);
        label2.TabIndex = 2;
        label2.Text = "Description";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(356, 237);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(112, 34);
        btnAdd.TabIndex = 4;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // FrmAddCategory
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnAdd);
        Controls.Add(txtDescription);
        Controls.Add(label2);
        Controls.Add(txtName);
        Controls.Add(label1);
        Name = "FrmAddCategory";
        Text = "FrmAddCategory";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtName;
    private TextBox txtDescription;
    private Label label2;
    private Button btnAdd;
}