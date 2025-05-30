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
    private void InitializeComponent()
    {
        panel1 = new System.Windows.Forms.Panel();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        panel2 = new System.Windows.Forms.Panel();
        selectCombobox = new System.Windows.Forms.ComboBox();
        transitionCombobx = new System.Windows.Forms.ComboBox();
        interpolationCombobox = new System.Windows.Forms.ComboBox();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        sigma = new System.Windows.Forms.TextBox();
        threshold = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        applyBtn = new System.Windows.Forms.Button();
        resetBtn = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
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
        panel1.Size = new System.Drawing.Size(304, 327);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(panel2, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 265F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
        tableLayoutPanel1.Size = new System.Drawing.Size(304, 327);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.Controls.Add(selectCombobox);
        panel2.Controls.Add(transitionCombobx);
        panel2.Controls.Add(interpolationCombobox);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(label4);
        panel2.Controls.Add(sigma);
        panel2.Controls.Add(threshold);
        panel2.Controls.Add(label3);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(label1);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(3, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(298, 259);
        panel2.TabIndex = 0;
        // 
        // selectCombobox
        // 
        selectCombobox.FormattingEnabled = true;
        selectCombobox.Location = new System.Drawing.Point(142, 216);
        selectCombobox.Name = "selectCombobox";
        selectCombobox.Size = new System.Drawing.Size(137, 28);
        selectCombobox.TabIndex = 2;
        selectCombobox.SelectionChangeCommitted += selectCombobox_SelectionChangeCommitted;
        // 
        // transitionCombobx
        // 
        transitionCombobx.FormattingEnabled = true;
        transitionCombobx.Location = new System.Drawing.Point(142, 173);
        transitionCombobx.Name = "transitionCombobx";
        transitionCombobx.Size = new System.Drawing.Size(137, 28);
        transitionCombobx.TabIndex = 2;
        transitionCombobx.SelectionChangeCommitted += transitionCombobx_SelectionChangeCommitted;
        // 
        // interpolationCombobox
        // 
        interpolationCombobox.FormattingEnabled = true;
        interpolationCombobox.Location = new System.Drawing.Point(142, 22);
        interpolationCombobox.Name = "interpolationCombobox";
        interpolationCombobox.Size = new System.Drawing.Size(137, 28);
        interpolationCombobox.TabIndex = 2;
        interpolationCombobox.SelectionChangeCommitted += interpolationCombobox_SelectionChangeCommitted;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(18, 216);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(109, 38);
        label5.TabIndex = 0;
        label5.Text = "Select";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(18, 163);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(109, 38);
        label4.TabIndex = 0;
        label4.Text = "Transition";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // sigma
        // 
        sigma.Location = new System.Drawing.Point(142, 74);
        sigma.Name = "sigma";
        sigma.Size = new System.Drawing.Size(137, 27);
        sigma.TabIndex = 1;
        sigma.TextChanged += sigma_TextChanged;
        // 
        // threshold
        // 
        threshold.Location = new System.Drawing.Point(142, 118);
        threshold.Name = "threshold";
        threshold.Size = new System.Drawing.Size(137, 27);
        threshold.TabIndex = 1;
        threshold.TextChanged += threshold_TextChanged;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(18, 112);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(109, 38);
        label3.TabIndex = 0;
        label3.Text = "Threshold";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(18, 63);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(109, 38);
        label2.TabIndex = 0;
        label2.Text = "Sigma";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(18, 16);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(109, 38);
        label1.TabIndex = 0;
        label1.Text = "Interpolation";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(applyBtn, 0, 0);
        tableLayoutPanel2.Controls.Add(resetBtn, 1, 0);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 268);
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
        // Config
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(304, 327);
        Controls.Add(panel1);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(322, 374);
        MinimumSize = new System.Drawing.Size(322, 374);
        Text = "Config";
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox selectCombobox;

    private System.Windows.Forms.ComboBox interpolationCombobox;
    private System.Windows.Forms.ComboBox transitionCombobx;
    private System.Windows.Forms.TextBox sigma;

    #endregion

    private Panel panel1;
    private TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel2;
    private Label label1;
    private Label label2;
    private System.Windows.Forms.TextBox threshold;
    private Label label3;
    private Label label4;
    private Label label5;
    private TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button applyBtn;
    private System.Windows.Forms.Button resetBtn;
}