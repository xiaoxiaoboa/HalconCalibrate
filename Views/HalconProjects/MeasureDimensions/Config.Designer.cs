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
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        applyBtn = new System.Windows.Forms.Button();
        resetBtn = new System.Windows.Forms.Button();
        groupBox2 = new System.Windows.Forms.GroupBox();
        checkBox2 = new System.Windows.Forms.CheckBox();
        checkBox1 = new System.Windows.Forms.CheckBox();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panel2.SuspendLayout();
        groupBox1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(304, 413);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(panel2, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
        tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 284F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
        tableLayoutPanel1.Size = new System.Drawing.Size(304, 413);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.Controls.Add(groupBox1);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(3, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(298, 278);
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
        groupBox1.Size = new System.Drawing.Size(298, 278);
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
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(applyBtn, 0, 0);
        tableLayoutPanel2.Controls.Add(resetBtn, 1, 0);
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 357);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new System.Drawing.Size(298, 54);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // applyBtn
        // 
        applyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
        applyBtn.Location = new System.Drawing.Point(3, 3);
        applyBtn.Name = "applyBtn";
        applyBtn.Size = new System.Drawing.Size(143, 48);
        applyBtn.TabIndex = 0;
        applyBtn.Text = "应用";
        applyBtn.UseVisualStyleBackColor = true;
        applyBtn.Click += applyBtn_Click;
        // 
        // resetBtn
        // 
        resetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
        resetBtn.Location = new System.Drawing.Point(152, 3);
        resetBtn.Name = "resetBtn";
        resetBtn.Size = new System.Drawing.Size(143, 48);
        resetBtn.TabIndex = 1;
        resetBtn.Text = "重置";
        resetBtn.UseVisualStyleBackColor = true;
        resetBtn.Click += resetBtn_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(checkBox2);
        groupBox2.Controls.Add(checkBox1);
        groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox2.Location = new System.Drawing.Point(3, 287);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(298, 64);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "测量方向";
        // 
        // checkBox2
        // 
        checkBox2.Location = new System.Drawing.Point(172, 26);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new System.Drawing.Size(60, 26);
        checkBox2.TabIndex = 1;
        checkBox2.Text = "Y轴";
        checkBox2.UseVisualStyleBackColor = true;
        checkBox2.CheckedChanged += checkBox2_CheckedChanged;
        // 
        // checkBox1
        // 
        checkBox1.Location = new System.Drawing.Point(80, 26);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(61, 26);
        checkBox1.TabIndex = 0;
        checkBox1.Text = "X轴";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // Config
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(304, 413);
        Controls.Add(panel1);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(322, 460);
        MinimumSize = new System.Drawing.Size(322, 374);
        Text = "Config";
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;

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
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button applyBtn;
    private System.Windows.Forms.Button resetBtn;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
}