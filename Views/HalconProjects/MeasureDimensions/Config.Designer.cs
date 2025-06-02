using System.ComponentModel;

namespace HalconCalibration.Views.HalconProjects.MeasureDimensions;

partial class Config
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
    private void InitializeComponent() {
        panel1 = new System.Windows.Forms.Panel();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        panel2 = new System.Windows.Forms.Panel();
        groupBox1 = new System.Windows.Forms.GroupBox();
        label1 = new System.Windows.Forms.Label();
        selectCombobox = new System.Windows.Forms.ComboBox();
        interpolationCombobox = new System.Windows.Forms.ComboBox();
        label5 = new System.Windows.Forms.Label();
        transitionCombobx = new System.Windows.Forms.ComboBox();
        label2 = new System.Windows.Forms.Label();
        sigma = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        threshold = new System.Windows.Forms.TextBox();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        resetBtn = new System.Windows.Forms.Button();
        applyBtn = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panel2.SuspendLayout();
        groupBox1.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(304, 367);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(panel2, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 291F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new System.Drawing.Size(304, 367);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.Controls.Add(groupBox1);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(3, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(298, 285);
        panel2.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(selectCombobox);
        groupBox1.Controls.Add(interpolationCombobox);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(transitionCombobx);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(sigma);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(threshold);
        groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox1.Location = new System.Drawing.Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(298, 285);
        groupBox1.TabIndex = 3;
        groupBox1.TabStop = false;
        groupBox1.Text = "算子参数";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(6, 23);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(109, 38);
        label1.TabIndex = 0;
        label1.Text = "Interpolation";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // selectCombobox
        // 
        selectCombobox.FormattingEnabled = true;
        selectCombobox.Location = new System.Drawing.Point(130, 237);
        selectCombobox.Name = "selectCombobox";
        selectCombobox.Size = new System.Drawing.Size(137, 28);
        selectCombobox.TabIndex = 2;
        selectCombobox.SelectionChangeCommitted += selectCombobox_SelectionChangeCommitted;
        // 
        // interpolationCombobox
        // 
        interpolationCombobox.FormattingEnabled = true;
        interpolationCombobox.Location = new System.Drawing.Point(130, 28);
        interpolationCombobox.Name = "interpolationCombobox";
        interpolationCombobox.Size = new System.Drawing.Size(137, 28);
        interpolationCombobox.TabIndex = 2;
        interpolationCombobox.SelectionChangeCommitted += interpolationCombobox_SelectionChangeCommitted;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(6, 228);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(109, 38);
        label5.TabIndex = 0;
        label5.Text = "Select";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // transitionCombobx
        // 
        transitionCombobx.FormattingEnabled = true;
        transitionCombobx.Location = new System.Drawing.Point(130, 177);
        transitionCombobx.Name = "transitionCombobx";
        transitionCombobx.Size = new System.Drawing.Size(137, 28);
        transitionCombobx.TabIndex = 2;
        transitionCombobx.SelectionChangeCommitted += transitionCombobx_SelectionChangeCommitted;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(6, 65);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(109, 38);
        label2.TabIndex = 0;
        label2.Text = "Sigma";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // sigma
        // 
        sigma.Location = new System.Drawing.Point(130, 71);
        sigma.Name = "sigma";
        sigma.Size = new System.Drawing.Size(137, 27);
        sigma.TabIndex = 1;
        sigma.TextChanged += sigma_TextChanged;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(6, 171);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(109, 38);
        label4.TabIndex = 0;
        label4.Text = "Transition";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(6, 118);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(109, 38);
        label3.TabIndex = 0;
        label3.Text = "Threshold";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // threshold
        // 
        threshold.Location = new System.Drawing.Point(130, 124);
        threshold.Name = "threshold";
        threshold.Size = new System.Drawing.Size(137, 27);
        threshold.TabIndex = 1;
        threshold.TextChanged += threshold_TextChanged;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 2;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.66443F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.33557F));
        tableLayoutPanel3.Controls.Add(resetBtn, 1, 0);
        tableLayoutPanel3.Controls.Add(applyBtn, 0, 0);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 294);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Size = new System.Drawing.Size(298, 73);
        tableLayoutPanel3.TabIndex = 2;
        // 
        // resetBtn
        // 
        resetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
        resetBtn.Location = new System.Drawing.Point(151, 3);
        resetBtn.Name = "resetBtn";
        resetBtn.Size = new System.Drawing.Size(144, 67);
        resetBtn.TabIndex = 1;
        resetBtn.Text = "重置";
        resetBtn.UseVisualStyleBackColor = true;
        resetBtn.Click += resetBtn_Click;
        // 
        // applyBtn
        // 
        applyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
        applyBtn.Location = new System.Drawing.Point(3, 3);
        applyBtn.Name = "applyBtn";
        applyBtn.Size = new System.Drawing.Size(142, 67);
        applyBtn.TabIndex = 0;
        applyBtn.Text = "应用";
        applyBtn.UseVisualStyleBackColor = true;
        applyBtn.Click += applyBtn_Click;
        // 
        // Config
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(304, 367);
        Controls.Add(panel1);
        MaximizeBox = false;
        Text = "Config";
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        tableLayoutPanel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox selectCombobox;

    private System.Windows.Forms.ComboBox interpolationCombobox;
    private System.Windows.Forms.ComboBox transitionCombobx;
    private System.Windows.Forms.TextBox sigma;

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel2;
    private Label label1;
    private Label label2;
    private System.Windows.Forms.TextBox threshold;
    private Label label3;
    private Label label4;
    private Label label5;
    private System.Windows.Forms.Button applyBtn;
    private System.Windows.Forms.Button resetBtn;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
}