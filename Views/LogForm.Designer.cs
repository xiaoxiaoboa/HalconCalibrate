using System.ComponentModel;

namespace HalconCalibration.Views;

partial class LogForm
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
        dataGridView1 = new System.Windows.Forms.DataGridView();
        panel1 = new System.Windows.Forms.Panel();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        exportLogs = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panel1.SuspendLayout();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
        dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        dataGridView1.EnableHeadersVisualStyles = false;
        dataGridView1.Location = new System.Drawing.Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(800, 422);
        dataGridView1.TabIndex = 0;
        dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
        dataGridView1.RowsAdded += dataGridView1_RowsAdded;
        // 
        // panel1
        // 
        panel1.Controls.Add(dataGridView1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 28);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(800, 422);
        panel1.TabIndex = 1;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { exportLogs });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(800, 28);
        menuStrip1.TabIndex = 2;
        menuStrip1.Text = "menuStrip1";
        // 
        // exportLogs
        // 
        exportLogs.Name = "exportLogs";
        exportLogs.Size = new System.Drawing.Size(53, 24);
        exportLogs.Text = "导出";
        exportLogs.Click += exportLogs_Click;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
        // 
        // LogForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Logs";
        Load += Logs_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        panel1.ResumeLayout(false);
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
    
    private System.Windows.Forms.Panel panel1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem exportLogs;
}