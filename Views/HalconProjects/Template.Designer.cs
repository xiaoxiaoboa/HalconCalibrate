using System.ComponentModel;

namespace HalconCalibration.Views.HalconProjects;

partial class Template
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new Panel();
        panel3 = new Panel();
        tableLayoutPanel1 = new TableLayoutPanel();
        panel2 = new Panel();
        tableLayoutPanel3 = new TableLayoutPanel();
        panel4 = new Panel();
        applyBtn = new Button();
        panel5 = new Panel();
        resetBtn = new Button();
        panel1.SuspendLayout();
        panel3.SuspendLayout();
        panel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        panel4.SuspendLayout();
        panel5.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(panel3);
        panel1.Controls.Add(panel2);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(312, 371);
        panel1.TabIndex = 0;
        // 
        // panel3
        // 
        panel3.AutoScroll = true;
        panel3.BorderStyle = BorderStyle.Fixed3D;
        panel3.Controls.Add(tableLayoutPanel1);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 44);
        panel3.Name = "panel3";
        panel3.Size = new Size(312, 327);
        panel3.TabIndex = 2;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoScroll = true;
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.44156F));
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.Size = new Size(308, 325);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.Controls.Add(tableLayoutPanel3);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(312, 44);
        panel2.TabIndex = 1;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 2;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(panel4, 0, 0);
        tableLayoutPanel3.Controls.Add(panel5, 1, 0);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(0, 0);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.Size = new Size(312, 44);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // panel4
        // 
        panel4.Controls.Add(applyBtn);
        panel4.Dock = DockStyle.Fill;
        panel4.Location = new Point(3, 3);
        panel4.Name = "panel4";
        panel4.Padding = new Padding(10, 0, 10, 0);
        panel4.Size = new Size(150, 38);
        panel4.TabIndex = 0;
        // 
        // applyBtn
        // 
        applyBtn.Dock = DockStyle.Fill;
        applyBtn.Location = new Point(10, 0);
        applyBtn.Name = "applyBtn";
        applyBtn.Size = new Size(130, 38);
        applyBtn.TabIndex = 0;
        applyBtn.Text = "应用";
        applyBtn.UseVisualStyleBackColor = true;
        applyBtn.Click += applyBtn_Click;
        // 
        // panel5
        // 
        panel5.Controls.Add(resetBtn);
        panel5.Dock = DockStyle.Fill;
        panel5.Location = new Point(159, 3);
        panel5.Name = "panel5";
        panel5.Padding = new Padding(10, 0, 10, 0);
        panel5.Size = new Size(150, 38);
        panel5.TabIndex = 1;
        // 
        // resetBtn
        // 
        resetBtn.Dock = DockStyle.Fill;
        resetBtn.Location = new Point(10, 0);
        resetBtn.Name = "resetBtn";
        resetBtn.Size = new Size(130, 38);
        resetBtn.TabIndex = 0;
        resetBtn.Text = "重置";
        resetBtn.UseVisualStyleBackColor = true;
        resetBtn.Click += resetBtn_Click;
        // 
        // Template
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(panel1);
        Name = "Template";
        Size = new Size(312, 371);
        panel1.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        panel4.ResumeLayout(false);
        panel5.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    protected System.Windows.Forms.Panel panel1;

    #endregion

    protected Panel panel3;
    protected Panel panel2;
    protected TableLayoutPanel tableLayoutPanel3;
    protected Panel panel4;
    protected System.Windows.Forms.Button applyBtn;
    protected Panel panel5;
    protected System.Windows.Forms.Button resetBtn;
}