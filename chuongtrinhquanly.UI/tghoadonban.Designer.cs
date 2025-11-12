namespace chuongtrinhquanly.UI;

partial class tghoadonban
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        label2 = new Label();
        dateTimePicker1 = new DateTimePicker();
        dateTimePicker2 = new DateTimePicker();
        button1 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(24, 29);
        label1.Name = "label1";
        label1.Size = new Size(78, 15);
        label1.TabIndex = 0;
        label1.Text = "Ngày bắt đầu";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(24, 83);
        label2.Name = "label2";
        label2.Size = new Size(81, 15);
        label2.TabIndex = 1;
        label2.Text = "Ngày kết thúc";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new Point(132, 29);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(200, 23);
        dateTimePicker1.TabIndex = 2;
        // 
        // dateTimePicker2
        // 
        dateTimePicker2.Location = new Point(132, 77);
        dateTimePicker2.Name = "dateTimePicker2";
        dateTimePicker2.Size = new Size(200, 23);
        dateTimePicker2.TabIndex = 3;
        // 
        // button1
        // 
        button1.Location = new Point(24, 135);
        button1.Name = "button1";
        button1.Size = new Size(177, 23);
        button1.TabIndex = 4;
        button1.Text = "Xuất";
        button1.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(376, 248);
        Controls.Add(button1);
        Controls.Add(dateTimePicker2);
        Controls.Add(dateTimePicker1);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Thời gian:Hoá đơn bán";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private DateTimePicker dateTimePicker1;
    private DateTimePicker dateTimePicker2;
    private Button button1;
}
