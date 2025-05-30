using System.ComponentModel;

namespace HalconCalibration.Views.HalconProjects;

partial class Threshold
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new System.Windows.Forms.Panel();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        groupBox1 = new System.Windows.Forms.GroupBox();
        thresholdMax = new System.Windows.Forms.TextBox();
        thresholdMin = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        groupBox2 = new System.Windows.Forms.GroupBox();
        selectShapeMax = new System.Windows.Forms.TextBox();
        selectShapeMin = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        operatorComboBox = new System.Windows.Forms.ComboBox();
        label6 = new System.Windows.Forms.Label();
        featuresComboBox = new System.Windows.Forms.ComboBox();
        label5 = new System.Windows.Forms.Label();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        applyBtn = new System.Windows.Forms.Button();
        resetBtn = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        panel2.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(293, 417);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
        tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
        tableLayoutPanel1.Controls.Add(panel2, 0, 2);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
        tableLayoutPanel1.Size = new System.Drawing.Size(293, 417);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(thresholdMax);
        groupBox1.Controls.Add(thresholdMin);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox1.Location = new System.Drawing.Point(3, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(287, 111);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "threshold";
        // 
        // thresholdMax
        // 
        thresholdMax.Location = new System.Drawing.Point(116, 67);
        thresholdMax.Name = "thresholdMax";
        thresholdMax.Size = new System.Drawing.Size(152, 27);
        thresholdMax.TabIndex = 3;
        thresholdMax.TextChanged += thresholdMax_TextChanged;
        // 
        // thresholdMin
        // 
        thresholdMin.Location = new System.Drawing.Point(116, 26);
        thresholdMin.Name = "thresholdMin";
        thresholdMin.Size = new System.Drawing.Size(152, 27);
        thresholdMin.TabIndex = 2;
        thresholdMin.TextChanged += thresholdMin_TextChanged;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(29, 70);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(67, 20);
        label2.TabIndex = 1;
        label2.Text = "最大值";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(29, 28);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(69, 23);
        label1.TabIndex = 0;
        label1.Text = "最小值";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(selectShapeMax);
        groupBox2.Controls.Add(selectShapeMin);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label4);
        groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox2.Location = new System.Drawing.Point(3, 120);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(287, 123);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "selectshape";
        // 
        // selectShapeMax
        // 
        selectShapeMax.Location = new System.Drawing.Point(116, 77);
        selectShapeMax.Name = "selectShapeMax";
        selectShapeMax.Size = new System.Drawing.Size(152, 27);
        selectShapeMax.TabIndex = 3;
        selectShapeMax.TextChanged += selectShapeMax_TextChanged;
        // 
        // selectShapeMin
        // 
        selectShapeMin.Location = new System.Drawing.Point(116, 36);
        selectShapeMin.Name = "selectShapeMin";
        selectShapeMin.Size = new System.Drawing.Size(152, 27);
        selectShapeMin.TabIndex = 2;
        selectShapeMin.TextChanged += selectShapeMin_TextChanged;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(29, 38);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(69, 23);
        label3.TabIndex = 0;
        label3.Text = "最小值";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(29, 80);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(67, 20);
        label4.TabIndex = 1;
        label4.Text = "最大值";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel2
        // 
        panel2.Controls.Add(operatorComboBox);
        panel2.Controls.Add(label6);
        panel2.Controls.Add(featuresComboBox);
        panel2.Controls.Add(label5);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(3, 249);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(287, 108);
        panel2.TabIndex = 2;
        // 
        // operatorComboBox
        // 
        operatorComboBox.FormattingEnabled = true;
        operatorComboBox.Location = new System.Drawing.Point(116, 67);
        operatorComboBox.Name = "operatorComboBox";
        operatorComboBox.Size = new System.Drawing.Size(152, 28);
        operatorComboBox.TabIndex = 1;
        operatorComboBox.SelectionChangeCommitted += operatorComboBox_SelectionChangeCommitted;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(31, 70);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(67, 20);
        label6.TabIndex = 1;
        label6.Text = "operator";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // featuresComboBox
        // 
        featuresComboBox.FormattingEnabled = true;
        featuresComboBox.Location = new System.Drawing.Point(116, 20);
        featuresComboBox.Name = "featuresComboBox";
        featuresComboBox.Size = new System.Drawing.Size(152, 28);
        featuresComboBox.TabIndex = 1;
        featuresComboBox.SelectionChangeCommitted += featuresComboBox_SelectionChangeCommitted;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(31, 23);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(67, 20);
        label5.TabIndex = 1;
        label5.Text = "feature";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(applyBtn, 0, 0);
        tableLayoutPanel2.Controls.Add(resetBtn, 1, 0);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 363);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new System.Drawing.Size(287, 51);
        tableLayoutPanel2.TabIndex = 3;
        // 
        // applyBtn
        // 
        applyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
        applyBtn.Location = new System.Drawing.Point(3, 3);
        applyBtn.Name = "applyBtn";
        applyBtn.Size = new System.Drawing.Size(137, 45);
        applyBtn.TabIndex = 0;
        applyBtn.Text = "应用";
        applyBtn.UseVisualStyleBackColor = true;
        applyBtn.Click += applyBtn_Click;
        // 
        // resetBtn
        // 
        resetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
        resetBtn.Location = new System.Drawing.Point(146, 3);
        resetBtn.Name = "resetBtn";
        resetBtn.Size = new System.Drawing.Size(138, 45);
        resetBtn.TabIndex = 1;
        resetBtn.Text = "重置";
        resetBtn.UseVisualStyleBackColor = true;
        resetBtn.Click += resetBtn_Click;
        // 
        // Threshold
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(293, 417);
        Controls.Add(panel1);
        MaximizeBox = false;
        MinimumSize = new System.Drawing.Size(311, 416);
        Text = "Threshold";
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        panel2.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button resetBtn;

    private System.Windows.Forms.Button applyBtn;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox thresholdMin;
    private System.Windows.Forms.TextBox thresholdMax;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;

    #endregion

    private GroupBox groupBox2;
    private System.Windows.Forms.TextBox selectShapeMax;
    private System.Windows.Forms.TextBox selectShapeMin;
    private Label label3;
    private Label label4;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.ComboBox featuresComboBox;
    private Label label5;
    private System.Windows.Forms.ComboBox operatorComboBox;
    private System.Windows.Forms.Label label6;
}