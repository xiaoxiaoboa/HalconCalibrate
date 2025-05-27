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
        tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
        label1 = new System.Windows.Forms.Label();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        thresholdMin = new System.Windows.Forms.TextBox();
        thresholdMax = new System.Windows.Forms.TextBox();
        tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
        label4 = new System.Windows.Forms.Label();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        selectShapeMin = new System.Windows.Forms.TextBox();
        selectShapeMax = new System.Windows.Forms.TextBox();
        tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
        label7 = new System.Windows.Forms.Label();
        featuresComboBox = new System.Windows.Forms.ComboBox();
        tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
        operatorComboBox = new System.Windows.Forms.ComboBox();
        label8 = new System.Windows.Forms.Label();
        tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
        panel6 = new System.Windows.Forms.Panel();
        listenPlc = new System.Windows.Forms.Button();
        panel7 = new System.Windows.Forms.Panel();
        stopListen = new System.Windows.Forms.Button();
        panel2 = new System.Windows.Forms.Panel();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        panel4 = new System.Windows.Forms.Panel();
        button1 = new System.Windows.Forms.Button();
        panel5 = new System.Windows.Forms.Panel();
        button2 = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        panel3.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel6.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel7.SuspendLayout();
        tableLayoutPanel8.SuspendLayout();
        tableLayoutPanel9.SuspendLayout();
        panel6.SuspendLayout();
        panel7.SuspendLayout();
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
        panel3.AutoScroll = true;
        panel3.BackColor = System.Drawing.SystemColors.Control;
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
        tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 1);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 2);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 3);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 0, 4);
        tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
        tableLayoutPanel1.Size = new System.Drawing.Size(265, 400);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 2;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.141844F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.858154F));
        tableLayoutPanel5.Controls.Add(label1, 0, 0);
        tableLayoutPanel5.Controls.Add(tableLayoutPanel2, 1, 0);
        tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 1;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.Size = new System.Drawing.Size(259, 94);
        tableLayoutPanel5.TabIndex = 0;
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Location = new System.Drawing.Point(3, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(72, 94);
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
        tableLayoutPanel2.Location = new System.Drawing.Point(81, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new System.Drawing.Size(175, 88);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // label2
        // 
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Location = new System.Drawing.Point(3, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(39, 44);
        label2.TabIndex = 0;
        label2.Text = "Min";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Dock = System.Windows.Forms.DockStyle.Fill;
        label3.Location = new System.Drawing.Point(3, 44);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(39, 44);
        label3.TabIndex = 1;
        label3.Text = "Max";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // thresholdMin
        // 
        thresholdMin.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        thresholdMin.Location = new System.Drawing.Point(48, 8);
        thresholdMin.Name = "thresholdMin";
        thresholdMin.Size = new System.Drawing.Size(124, 27);
        thresholdMin.TabIndex = 2;
        thresholdMin.TextChanged += thresholdMin_TextChanged;
        // 
        // thresholdMax
        // 
        thresholdMax.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        thresholdMax.Location = new System.Drawing.Point(48, 52);
        thresholdMax.Name = "thresholdMax";
        thresholdMax.Size = new System.Drawing.Size(124, 27);
        thresholdMax.TabIndex = 3;
        thresholdMax.TextChanged += thresholdMax_TextChanged;
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 2;
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.496454F));
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.50355F));
        tableLayoutPanel6.Controls.Add(label4, 0, 0);
        tableLayoutPanel6.Controls.Add(tableLayoutPanel4, 1, 0);
        tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel6.Location = new System.Drawing.Point(3, 103);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 1;
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.Size = new System.Drawing.Size(259, 94);
        tableLayoutPanel6.TabIndex = 1;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Dock = System.Windows.Forms.DockStyle.Fill;
        label4.Location = new System.Drawing.Point(3, 0);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(72, 94);
        label4.TabIndex = 2;
        label4.Text = "select";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 2;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.882353F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.117645F));
        tableLayoutPanel4.Controls.Add(label5, 0, 0);
        tableLayoutPanel4.Controls.Add(label6, 0, 1);
        tableLayoutPanel4.Controls.Add(selectShapeMin, 1, 0);
        tableLayoutPanel4.Controls.Add(selectShapeMax, 1, 1);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(81, 3);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 2;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.Size = new System.Drawing.Size(175, 88);
        tableLayoutPanel4.TabIndex = 3;
        // 
        // label5
        // 
        label5.Dock = System.Windows.Forms.DockStyle.Fill;
        label5.Location = new System.Drawing.Point(3, 0);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(39, 44);
        label5.TabIndex = 0;
        label5.Text = "Min";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label6
        // 
        label6.Dock = System.Windows.Forms.DockStyle.Fill;
        label6.Location = new System.Drawing.Point(3, 44);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(39, 44);
        label6.TabIndex = 1;
        label6.Text = "Max";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // selectShapeMin
        // 
        selectShapeMin.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        selectShapeMin.Location = new System.Drawing.Point(48, 8);
        selectShapeMin.Name = "selectShapeMin";
        selectShapeMin.Size = new System.Drawing.Size(124, 27);
        selectShapeMin.TabIndex = 2;
        selectShapeMin.TextChanged += selectShapeMin_TextChanged;
        // 
        // selectShapeMax
        // 
        selectShapeMax.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        selectShapeMax.Location = new System.Drawing.Point(48, 52);
        selectShapeMax.Name = "selectShapeMax";
        selectShapeMax.Size = new System.Drawing.Size(124, 27);
        selectShapeMax.TabIndex = 3;
        selectShapeMax.TextChanged += selectShapeMax_TextChanged;
        // 
        // tableLayoutPanel7
        // 
        tableLayoutPanel7.ColumnCount = 2;
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.826817F));
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.173183F));
        tableLayoutPanel7.Controls.Add(label7, 0, 0);
        tableLayoutPanel7.Controls.Add(featuresComboBox, 1, 0);
        tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel7.Location = new System.Drawing.Point(3, 203);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 1;
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.Size = new System.Drawing.Size(259, 60);
        tableLayoutPanel7.TabIndex = 2;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Dock = System.Windows.Forms.DockStyle.Fill;
        label7.Location = new System.Drawing.Point(3, 0);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(94, 60);
        label7.TabIndex = 4;
        label7.Text = "features";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // featuresComboBox
        // 
        featuresComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        featuresComboBox.FormattingEnabled = true;
        featuresComboBox.Location = new System.Drawing.Point(103, 16);
        featuresComboBox.Name = "featuresComboBox";
        featuresComboBox.Size = new System.Drawing.Size(153, 28);
        featuresComboBox.TabIndex = 5;
        featuresComboBox.SelectionChangeCommitted += featuresComboBox_SelectionChangeCommitted;
        // 
        // tableLayoutPanel8
        // 
        tableLayoutPanel8.ColumnCount = 2;
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.547485F));
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.452515F));
        tableLayoutPanel8.Controls.Add(operatorComboBox, 1, 0);
        tableLayoutPanel8.Controls.Add(label8, 0, 0);
        tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel8.Location = new System.Drawing.Point(3, 269);
        tableLayoutPanel8.Name = "tableLayoutPanel8";
        tableLayoutPanel8.RowCount = 1;
        tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel8.Size = new System.Drawing.Size(259, 58);
        tableLayoutPanel8.TabIndex = 3;
        // 
        // operatorComboBox
        // 
        operatorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        operatorComboBox.FormattingEnabled = true;
        operatorComboBox.Location = new System.Drawing.Point(102, 15);
        operatorComboBox.Name = "operatorComboBox";
        operatorComboBox.Size = new System.Drawing.Size(154, 28);
        operatorComboBox.TabIndex = 7;
        operatorComboBox.SelectionChangeCommitted += operatorComboBox_SelectionChangeCommitted;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Dock = System.Windows.Forms.DockStyle.Fill;
        label8.Location = new System.Drawing.Point(3, 0);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(93, 58);
        label8.TabIndex = 6;
        label8.Text = "operator";
        label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel9
        // 
        tableLayoutPanel9.ColumnCount = 2;
        tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel9.Controls.Add(panel6, 0, 0);
        tableLayoutPanel9.Controls.Add(panel7, 1, 0);
        tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel9.Location = new System.Drawing.Point(3, 333);
        tableLayoutPanel9.Name = "tableLayoutPanel9";
        tableLayoutPanel9.RowCount = 1;
        tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel9.Size = new System.Drawing.Size(259, 64);
        tableLayoutPanel9.TabIndex = 4;
        // 
        // panel6
        // 
        panel6.Controls.Add(listenPlc);
        panel6.Dock = System.Windows.Forms.DockStyle.Fill;
        panel6.Location = new System.Drawing.Point(3, 3);
        panel6.Name = "panel6";
        panel6.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
        panel6.Size = new System.Drawing.Size(123, 58);
        panel6.TabIndex = 0;
        // 
        // listenPlc
        // 
        listenPlc.Dock = System.Windows.Forms.DockStyle.Fill;
        listenPlc.Location = new System.Drawing.Point(15, 5);
        listenPlc.Name = "listenPlc";
        listenPlc.Size = new System.Drawing.Size(93, 48);
        listenPlc.TabIndex = 0;
        listenPlc.Text = "监听PLC";
        listenPlc.UseVisualStyleBackColor = true;
        listenPlc.Click += listenPlc_Click;
        // 
        // panel7
        // 
        panel7.Controls.Add(stopListen);
        panel7.Dock = System.Windows.Forms.DockStyle.Fill;
        panel7.Location = new System.Drawing.Point(132, 3);
        panel7.Name = "panel7";
        panel7.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
        panel7.Size = new System.Drawing.Size(124, 58);
        panel7.TabIndex = 1;
        // 
        // stopListen
        // 
        stopListen.Dock = System.Windows.Forms.DockStyle.Fill;
        stopListen.Location = new System.Drawing.Point(15, 5);
        stopListen.Name = "stopListen";
        stopListen.Size = new System.Drawing.Size(94, 48);
        stopListen.TabIndex = 0;
        stopListen.Text = "停止监听";
        stopListen.UseVisualStyleBackColor = true;
        stopListen.Click += stopListen_Click;
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
        tableLayoutPanel5.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        tableLayoutPanel6.ResumeLayout(false);
        tableLayoutPanel6.PerformLayout();
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        tableLayoutPanel7.ResumeLayout(false);
        tableLayoutPanel7.PerformLayout();
        tableLayoutPanel8.ResumeLayout(false);
        tableLayoutPanel8.PerformLayout();
        tableLayoutPanel9.ResumeLayout(false);
        panel6.ResumeLayout(false);
        panel7.ResumeLayout(false);
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
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox thresholdMin;
    private System.Windows.Forms.TextBox thresholdMax;
    private System.Windows.Forms.Panel panel3;
    private Panel panel2;
    private TableLayoutPanel tableLayoutPanel3;
    private Panel panel4;
    private System.Windows.Forms.Button button1;
    private Panel panel5;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox selectShapeMin;
    private System.Windows.Forms.TextBox selectShapeMax;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox featuresComboBox;
    private System.Windows.Forms.ComboBox operatorComboBox;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.Button listenPlc;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.Button stopListen;
}