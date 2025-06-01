using System.ComponentModel;

namespace HalconCalibration.Views;

partial class PlcConfig {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
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
        groupBox1 = new System.Windows.Forms.GroupBox();
        groupBox3 = new System.Windows.Forms.GroupBox();
        textBox2 = new System.Windows.Forms.TextBox();
        groupBox2 = new System.Windows.Forms.GroupBox();
        textBox1 = new System.Windows.Forms.TextBox();
        panel1.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(groupBox1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(424, 112);
        panel1.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(groupBox3);
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox1.Location = new System.Drawing.Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(424, 112);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "PLC配置";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(textBox2);
        groupBox3.Location = new System.Drawing.Point(269, 26);
        groupBox3.Name = "groupBox3";
        groupBox3.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
        groupBox3.Size = new System.Drawing.Size(124, 58);
        groupBox3.TabIndex = 0;
        groupBox3.TabStop = false;
        groupBox3.Text = "端口";
        // 
        // textBox2
        // 
        textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        textBox2.Location = new System.Drawing.Point(10, 23);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(104, 27);
        textBox2.TabIndex = 0;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(textBox1);
        groupBox2.Location = new System.Drawing.Point(12, 26);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
        groupBox2.Size = new System.Drawing.Size(212, 58);
        groupBox2.TabIndex = 0;
        groupBox2.TabStop = false;
        groupBox2.Text = "IP";
        // 
        // textBox1
        // 
        textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        textBox1.Location = new System.Drawing.Point(10, 23);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(192, 27);
        textBox1.TabIndex = 0;
        // 
        // PlcConfig
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(424, 112);
        Controls.Add(panel1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "PlcConfig";
        FormClosing += PlcConfig_FormClosing;
        Load += PlcConfig_Load;
        panel1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}