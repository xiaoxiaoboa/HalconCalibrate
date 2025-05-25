using System.ComponentModel;

namespace HalconCalibration.Views.HalconProjects;

partial class Calibration
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
        panel1 = new System.Windows.Forms.Panel();
        panel3 = new System.Windows.Forms.Panel();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        operatorComboBox = new System.Windows.Forms.ComboBox();
        label8 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        thresholdMin = new System.Windows.Forms.TextBox();
        thresholdMax = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        featuresComboBox = new System.Windows.Forms.ComboBox();
        panel2 = new System.Windows.Forms.Panel();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        panel4 = new System.Windows.Forms.Panel();
        button1 = new System.Windows.Forms.Button();
        panel5 = new System.Windows.Forms.Panel();
        button2 = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        panel3.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
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
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(312, 371);
        panel1.TabIndex = 0;
        // 
        // panel3
        // 
        panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        panel3.Controls.Add(tableLayoutPanel1);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(0, 44);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(312, 327);
        panel3.TabIndex = 2;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoScroll = true;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.44156F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.55844F));
        tableLayoutPanel1.Controls.Add(operatorComboBox, 1, 3);
        tableLayoutPanel1.Controls.Add(label8, 0, 3);
        tableLayoutPanel1.Controls.Add(label7, 0, 2);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
        tableLayoutPanel1.Controls.Add(label4, 0, 1);
        tableLayoutPanel1.Controls.Add(featuresComboBox, 1, 2);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.62963F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.148148F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.851852F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.37037F));
        tableLayoutPanel1.Size = new System.Drawing.Size(308, 323);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // operatorComboBox
        // 
        operatorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        operatorComboBox.FormattingEnabled = true;
        operatorComboBox.Location = new System.Drawing.Point(106, 275);
        operatorComboBox.Name = "operatorComboBox";
        operatorComboBox.Size = new System.Drawing.Size(199, 28);
        operatorComboBox.TabIndex = 7;
        operatorComboBox.SelectionChangeCommitted += operatorComboBox_SelectionChangeCommitted;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Dock = System.Windows.Forms.DockStyle.Fill;
        label8.Location = new System.Drawing.Point(3, 255);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(97, 68);
        label8.TabIndex = 6;
        label8.Text = "operator";
        label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Dock = System.Windows.Forms.DockStyle.Fill;
        label7.Location = new System.Drawing.Point(3, 185);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(97, 70);
        label7.TabIndex = 4;
        label7.Text = "features";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 2;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.882353F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.117645F));
        tableLayoutPanel4.Controls.Add(label5, 0, 0);
        tableLayoutPanel4.Controls.Add(label6, 0, 1);
        tableLayoutPanel4.Controls.Add(textBox1, 1, 0);
        tableLayoutPanel4.Controls.Add(textBox2, 1, 1);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(106, 98);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 2;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.Size = new System.Drawing.Size(199, 84);
        tableLayoutPanel4.TabIndex = 3;
        // 
        // label5
        // 
        label5.Dock = System.Windows.Forms.DockStyle.Fill;
        label5.Location = new System.Drawing.Point(3, 0);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(45, 42);
        label5.TabIndex = 0;
        label5.Text = "Min";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label6
        // 
        label6.Dock = System.Windows.Forms.DockStyle.Fill;
        label6.Location = new System.Drawing.Point(3, 42);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(45, 42);
        label6.TabIndex = 1;
        label6.Text = "Max";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBox1
        // 
        textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        textBox1.Location = new System.Drawing.Point(54, 7);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(142, 27);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        textBox2.Location = new System.Drawing.Point(54, 49);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(142, 27);
        textBox2.TabIndex = 3;
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Location = new System.Drawing.Point(3, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(97, 95);
        label1.TabIndex = 0;
        label1.Text = "threshold";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.882353F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.117645F));
        tableLayoutPanel2.Controls.Add(label2, 0, 0);
        tableLayoutPanel2.Controls.Add(label3, 0, 1);
        tableLayoutPanel2.Controls.Add(thresholdMin, 1, 0);
        tableLayoutPanel2.Controls.Add(thresholdMax, 1, 1);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(106, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new System.Drawing.Size(199, 89);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // label2
        // 
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Location = new System.Drawing.Point(3, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(45, 44);
        label2.TabIndex = 0;
        label2.Text = "Min";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Dock = System.Windows.Forms.DockStyle.Fill;
        label3.Location = new System.Drawing.Point(3, 44);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(45, 45);
        label3.TabIndex = 1;
        label3.Text = "Max";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // thresholdMin
        // 
        thresholdMin.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        thresholdMin.Location = new System.Drawing.Point(54, 8);
        thresholdMin.Name = "thresholdMin";
        thresholdMin.Size = new System.Drawing.Size(142, 27);
        thresholdMin.TabIndex = 2;
        // 
        // thresholdMax
        // 
        thresholdMax.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        thresholdMax.Location = new System.Drawing.Point(54, 53);
        thresholdMax.Name = "thresholdMax";
        thresholdMax.Size = new System.Drawing.Size(142, 27);
        thresholdMax.TabIndex = 3;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Dock = System.Windows.Forms.DockStyle.Fill;
        label4.Location = new System.Drawing.Point(3, 95);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(97, 90);
        label4.TabIndex = 2;
        label4.Text = "selectShape";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // featuresComboBox
        // 
        featuresComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        featuresComboBox.FormattingEnabled = true;
        featuresComboBox.Location = new System.Drawing.Point(106, 206);
        featuresComboBox.Name = "featuresComboBox";
        featuresComboBox.Size = new System.Drawing.Size(199, 28);
        featuresComboBox.TabIndex = 5;
        featuresComboBox.SelectionChangeCommitted += featuresComboBox_SelectionChangeCommitted;
        // 
        // panel2
        // 
        panel2.Controls.Add(tableLayoutPanel3);
        panel2.Dock = System.Windows.Forms.DockStyle.Top;
        panel2.Location = new System.Drawing.Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(312, 44);
        panel2.TabIndex = 1;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 2;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(panel4, 0, 0);
        tableLayoutPanel3.Controls.Add(panel5, 1, 0);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Size = new System.Drawing.Size(312, 44);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // panel4
        // 
        panel4.Controls.Add(button1);
        panel4.Dock = System.Windows.Forms.DockStyle.Fill;
        panel4.Location = new System.Drawing.Point(3, 3);
        panel4.Name = "panel4";
        panel4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
        panel4.Size = new System.Drawing.Size(150, 38);
        panel4.TabIndex = 0;
        // 
        // button1
        // 
        button1.Dock = System.Windows.Forms.DockStyle.Fill;
        button1.Location = new System.Drawing.Point(10, 0);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(130, 38);
        button1.TabIndex = 0;
        button1.Text = "应用";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // panel5
        // 
        panel5.Controls.Add(button2);
        panel5.Dock = System.Windows.Forms.DockStyle.Fill;
        panel5.Location = new System.Drawing.Point(159, 3);
        panel5.Name = "panel5";
        panel5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
        panel5.Size = new System.Drawing.Size(150, 38);
        panel5.TabIndex = 1;
        // 
        // button2
        // 
        button2.Dock = System.Windows.Forms.DockStyle.Fill;
        button2.Location = new System.Drawing.Point(10, 0);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(130, 38);
        button2.TabIndex = 0;
        button2.Text = "重置";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // Calibration
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(panel1);
        Size = new System.Drawing.Size(312, 371);
        panel1.ResumeLayout(false);
        panel3.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        panel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        panel4.ResumeLayout(false);
        panel5.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;

    #endregion

    private System.Windows.Forms.Label label1;
    private TableLayoutPanel tableLayoutPanel2;
    private Label label2;
    private Label label3;
    private TextBox thresholdMin;
    private TextBox thresholdMax;
    private Panel panel3;
    private Panel panel2;
    private TableLayoutPanel tableLayoutPanel3;
    private Panel panel4;
    private System.Windows.Forms.Button button1;
    private Panel panel5;
    private System.Windows.Forms.Button button2;
    private TableLayoutPanel tableLayoutPanel4;
    private Label label5;
    private Label label6;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label4;
    private Label label7;
    private System.Windows.Forms.ComboBox featuresComboBox;
    private System.Windows.Forms.ComboBox operatorComboBox;
    private System.Windows.Forms.Label label8;
}