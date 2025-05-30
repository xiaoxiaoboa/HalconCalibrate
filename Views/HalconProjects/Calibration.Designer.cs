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
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        thresholdBtn = new System.Windows.Forms.Button();
        start = new System.Windows.Forms.Button();
        stopListen = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(312, 371);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(thresholdBtn, 0, 0);
        tableLayoutPanel1.Controls.Add(start, 1, 0);
        tableLayoutPanel1.Controls.Add(stopListen, 0, 1);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
        tableLayoutPanel1.Size = new System.Drawing.Size(312, 371);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // thresholdBtn
        // 
        thresholdBtn.Dock = System.Windows.Forms.DockStyle.Fill;
        thresholdBtn.Location = new System.Drawing.Point(3, 3);
        thresholdBtn.Name = "thresholdBtn";
        thresholdBtn.Size = new System.Drawing.Size(150, 54);
        thresholdBtn.TabIndex = 0;
        thresholdBtn.Text = "阈值分割";
        thresholdBtn.UseVisualStyleBackColor = true;
        thresholdBtn.Click += thresholdBtn_Click;
        // 
        // start
        // 
        start.Dock = System.Windows.Forms.DockStyle.Fill;
        start.Location = new System.Drawing.Point(159, 3);
        start.Name = "start";
        start.Size = new System.Drawing.Size(150, 54);
        start.TabIndex = 1;
        start.Text = "启动标定";
        start.UseVisualStyleBackColor = true;
        start.Click += listenPlc_Click;
        // 
        // stopListen
        // 
        stopListen.Dock = System.Windows.Forms.DockStyle.Fill;
        stopListen.Location = new System.Drawing.Point(3, 63);
        stopListen.Name = "stopListen";
        stopListen.Size = new System.Drawing.Size(150, 54);
        stopListen.TabIndex = 2;
        stopListen.Text = "停止监听";
        stopListen.UseVisualStyleBackColor = true;
        stopListen.Click += stopListen_Click;
        // 
        // Calibration
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(panel1);
        Size = new System.Drawing.Size(312, 371);
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button thresholdBtn;
    private System.Windows.Forms.Button start;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;

    #endregion

    private Button stopListen;
}