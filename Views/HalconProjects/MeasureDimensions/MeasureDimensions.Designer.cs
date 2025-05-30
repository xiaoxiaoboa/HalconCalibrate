using System.ComponentModel;

namespace HalconCalibration.Views.HalconProjects.MeasureDimensions;

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
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        threshold = new System.Windows.Forms.Button();
        config = new System.Windows.Forms.Button();
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
        tableLayoutPanel1.Controls.Add(threshold, 0, 0);
        tableLayoutPanel1.Controls.Add(config, 1, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.094339F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.90566F));
        tableLayoutPanel1.Size = new System.Drawing.Size(312, 371);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // threshold
        // 
        threshold.Dock = System.Windows.Forms.DockStyle.Fill;
        threshold.Location = new System.Drawing.Point(3, 3);
        threshold.Name = "threshold";
        threshold.Size = new System.Drawing.Size(150, 50);
        threshold.TabIndex = 0;
        threshold.Text = "阈值分割";
        threshold.UseVisualStyleBackColor = true;
        threshold.Click += threshold_Click;
        // 
        // config
        // 
        config.Dock = System.Windows.Forms.DockStyle.Fill;
        config.Location = new System.Drawing.Point(159, 3);
        config.Name = "config";
        config.Size = new System.Drawing.Size(150, 50);
        config.TabIndex = 1;
        config.Text = "配置";
        config.UseVisualStyleBackColor = true;
        config.Click += config_Click;
        // 
        // MeasureDimensions
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(panel1);
        Size = new System.Drawing.Size(312, 371);
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button threshold;
    private System.Windows.Forms.Button config;

    private System.Windows.Forms.Panel panel1;

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
}