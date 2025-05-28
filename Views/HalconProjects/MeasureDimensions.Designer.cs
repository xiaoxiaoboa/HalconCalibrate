using System.ComponentModel;

namespace HalconCalibration.Views.HalconProjects;

partial class MeasureDimensions
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
        panel2 = new System.Windows.Forms.Panel();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        panel4 = new System.Windows.Forms.Panel();
        applyBtn = new System.Windows.Forms.Button();
        panel5 = new System.Windows.Forms.Panel();
        resetBtn = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        panel3.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel6.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel7.SuspendLayout();
        tableLayoutPanel8.SuspendLayout();
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
        tableLayoutPanel1.Location = new System.Drawing.Point(-2, -2);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
        tableLayoutPanel1.Size = new System.Drawing.Size(307, 322);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 2;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.935017F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.06498F));
        tableLayoutPanel5.Controls.Add(label1, 0, 0);
        tableLayoutPanel5.Controls.Add(tableLayoutPanel2, 1, 0);
        tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 1;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.Size = new System.Drawing.Size(301, 86);
        tableLayoutPanel5.TabIndex = 0;
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Location = new System.Drawing.Point(3, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(96, 86);
        label1.TabIndex = 0;
        label1.Text = "threshold";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.487804F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.51219F));
        tableLayoutPanel2.Controls.Add(label2, 0, 0);
        tableLayoutPanel2.Controls.Add(label3, 0, 1);
        tableLayoutPanel2.Controls.Add(thresholdMin, 1, 0);
        tableLayoutPanel2.Controls.Add(thresholdMax, 1, 1);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(105, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new System.Drawing.Size(193, 80);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // label2
        // 
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Location = new System.Drawing.Point(3, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(52, 40);
        label2.TabIndex = 0;
        label2.Text = "Min";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Dock = System.Windows.Forms.DockStyle.Fill;
        label3.Location = new System.Drawing.Point(3, 40);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(52, 40);
        label3.TabIndex = 1;
        label3.Text = "Max";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // thresholdMin
        // 
        thresholdMin.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        thresholdMin.Location = new System.Drawing.Point(61, 6);
        thresholdMin.Name = "thresholdMin";
        thresholdMin.Size = new System.Drawing.Size(129, 27);
        thresholdMin.TabIndex = 2;
        thresholdMin.TextChanged += thresholdMin_TextChanged;
        // 
        // thresholdMax
        // 
        thresholdMax.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        thresholdMax.Location = new System.Drawing.Point(61, 46);
        thresholdMax.Name = "thresholdMax";
        thresholdMax.Size = new System.Drawing.Size(129, 27);
        thresholdMax.TabIndex = 3;
        thresholdMax.TextChanged += thresholdMax_TextChanged;
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 2;
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.212997F));
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.787F));
        tableLayoutPanel6.Controls.Add(label4, 0, 0);
        tableLayoutPanel6.Controls.Add(tableLayoutPanel4, 1, 0);
        tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel6.Location = new System.Drawing.Point(3, 95);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 1;
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.Size = new System.Drawing.Size(301, 85);
        tableLayoutPanel6.TabIndex = 1;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Dock = System.Windows.Forms.DockStyle.Fill;
        label4.Location = new System.Drawing.Point(3, 0);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(93, 85);
        label4.TabIndex = 2;
        label4.Text = "select";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 2;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.90909F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.09091F));
        tableLayoutPanel4.Controls.Add(label5, 0, 0);
        tableLayoutPanel4.Controls.Add(label6, 0, 1);
        tableLayoutPanel4.Controls.Add(selectShapeMin, 1, 0);
        tableLayoutPanel4.Controls.Add(selectShapeMax, 1, 1);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(102, 3);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 2;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.Size = new System.Drawing.Size(196, 79);
        tableLayoutPanel4.TabIndex = 3;
        // 
        // label5
        // 
        label5.Dock = System.Windows.Forms.DockStyle.Fill;
        label5.Location = new System.Drawing.Point(3, 0);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(54, 39);
        label5.TabIndex = 0;
        label5.Text = "Min";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label6
        // 
        label6.Dock = System.Windows.Forms.DockStyle.Fill;
        label6.Location = new System.Drawing.Point(3, 39);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(54, 40);
        label6.TabIndex = 1;
        label6.Text = "Max";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // selectShapeMin
        // 
        selectShapeMin.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        selectShapeMin.Location = new System.Drawing.Point(63, 6);
        selectShapeMin.Name = "selectShapeMin";
        selectShapeMin.Size = new System.Drawing.Size(130, 27);
        selectShapeMin.TabIndex = 2;
        selectShapeMin.TextChanged += selectShapeMin_TextChanged;
        // 
        // selectShapeMax
        // 
        selectShapeMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        selectShapeMax.Location = new System.Drawing.Point(63, 42);
        selectShapeMax.Name = "selectShapeMax";
        selectShapeMax.Size = new System.Drawing.Size(130, 27);
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
        tableLayoutPanel7.Location = new System.Drawing.Point(3, 186);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 1;
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.Size = new System.Drawing.Size(301, 63);
        tableLayoutPanel7.TabIndex = 2;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Dock = System.Windows.Forms.DockStyle.Fill;
        label7.Location = new System.Drawing.Point(3, 0);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(110, 63);
        label7.TabIndex = 4;
        label7.Text = "features";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // featuresComboBox
        // 
        featuresComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        featuresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        featuresComboBox.FormattingEnabled = true;
        featuresComboBox.Location = new System.Drawing.Point(119, 17);
        featuresComboBox.Name = "featuresComboBox";
        featuresComboBox.Size = new System.Drawing.Size(179, 28);
        featuresComboBox.TabIndex = 5;
        featuresComboBox.TabStop = false;
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
        tableLayoutPanel8.Location = new System.Drawing.Point(3, 255);
        tableLayoutPanel8.Name = "tableLayoutPanel8";
        tableLayoutPanel8.RowCount = 1;
        tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel8.Size = new System.Drawing.Size(301, 64);
        tableLayoutPanel8.TabIndex = 3;
        // 
        // operatorComboBox
        // 
        operatorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        operatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        operatorComboBox.FormattingEnabled = true;
        operatorComboBox.Location = new System.Drawing.Point(119, 18);
        operatorComboBox.Name = "operatorComboBox";
        operatorComboBox.Size = new System.Drawing.Size(179, 28);
        operatorComboBox.TabIndex = 7;
        operatorComboBox.SelectionChangeCommitted += operatorComboBox_SelectionChangeCommitted;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Dock = System.Windows.Forms.DockStyle.Fill;
        label8.Location = new System.Drawing.Point(3, 0);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(110, 64);
        label8.TabIndex = 6;
        label8.Text = "operator";
        label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        panel4.Controls.Add(applyBtn);
        panel4.Dock = System.Windows.Forms.DockStyle.Fill;
        panel4.Location = new System.Drawing.Point(3, 3);
        panel4.Name = "panel4";
        panel4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
        panel4.Size = new System.Drawing.Size(150, 38);
        panel4.TabIndex = 0;
        // 
        // applyBtn
        // 
        applyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
        applyBtn.Location = new System.Drawing.Point(10, 0);
        applyBtn.Name = "applyBtn";
        applyBtn.Size = new System.Drawing.Size(130, 38);
        applyBtn.TabIndex = 0;
        applyBtn.Text = "应用";
        applyBtn.UseVisualStyleBackColor = true;
        applyBtn.Click += applyBtn_Click;
        // 
        // panel5
        // 
        panel5.Controls.Add(resetBtn);
        panel5.Dock = System.Windows.Forms.DockStyle.Fill;
        panel5.Location = new System.Drawing.Point(159, 3);
        panel5.Name = "panel5";
        panel5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
        panel5.Size = new System.Drawing.Size(150, 38);
        panel5.TabIndex = 1;
        // 
        // resetBtn
        // 
        resetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
        resetBtn.Location = new System.Drawing.Point(10, 0);
        resetBtn.Name = "resetBtn";
        resetBtn.Size = new System.Drawing.Size(130, 38);
        resetBtn.TabIndex = 0;
        resetBtn.Text = "重置";
        resetBtn.UseVisualStyleBackColor = true;
        resetBtn.Click += resetBtn_Click;
        // 
        // MeasureDimensions
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(panel1);
        Size = new System.Drawing.Size(312, 371);
        Load += MeasureDimensions_Load;
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
        panel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        panel4.ResumeLayout(false);
        panel5.ResumeLayout(false);
        ResumeLayout(false);
    }

    protected System.Windows.Forms.Panel panel1;

    #endregion

    protected Panel panel3;
    protected Panel panel2;
    protected TableLayoutPanel tableLayoutPanel3;
    protected Panel panel4;
    protected System.Windows.Forms.Button applyBtn;
    protected Panel panel5;
    protected System.Windows.Forms.Button resetBtn;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox thresholdMin;
    private System.Windows.Forms.TextBox thresholdMax;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox selectShapeMin;
    private System.Windows.Forms.TextBox selectShapeMax;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox featuresComboBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
    private System.Windows.Forms.ComboBox operatorComboBox;
    private System.Windows.Forms.Label label8;
}