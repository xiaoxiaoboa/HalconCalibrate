using System.ComponentModel;

namespace HalconCalibration.Views;

partial class Logs
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
        dataGridView1 = new DataGridView();
        panel1 = new Panel();
        menuStrip1 = new MenuStrip();
        exportLogs = new ToolStripMenuItem();
        ((ISupportInitialize)dataGridView1).BeginInit();
        panel1.SuspendLayout();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataGridView1.BackgroundColor = SystemColors.Control;
        dataGridView1.BorderStyle = BorderStyle.Fixed3D;
        dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Dock = DockStyle.Fill;
        dataGridView1.EnableHeadersVisualStyles = false;
        dataGridView1.Location = new Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(800, 422);
        dataGridView1.TabIndex = 0;
        dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
        // 
        // panel1
        // 
        panel1.Controls.Add(dataGridView1);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 28);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 422);
        panel1.TabIndex = 1;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { exportLogs });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(800, 28);
        menuStrip1.TabIndex = 2;
        menuStrip1.Text = "menuStrip1";
        // 
        // exportLogs
        // 
        exportLogs.Name = "exportLogs";
        exportLogs.Size = new Size(53, 24);
        exportLogs.Text = "导出";
        exportLogs.Click += exportLogs_Click;
        // 
        // Logs
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Logs";
        Text = "Logs";
        Load += Logs_Load;
        ((ISupportInitialize)dataGridView1).EndInit();
        panel1.ResumeLayout(false);
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion

    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private Panel panel1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem exportLogs;
}