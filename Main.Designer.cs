namespace HalconCalibration;

partial class Main
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        menuStrip1 = new MenuStrip();
        projects = new ToolStripMenuItem();
        ninePointCalib = new ToolStripMenuItem();
        toolStripMenuItem1 = new ToolStripMenuItem();
        toolStripMenuItem2 = new ToolStripMenuItem();
        panel1 = new Panel();
        tableLayoutPanel1 = new TableLayoutPanel();
        hSmartWindowControl1 = new HalconDotNet.HSmartWindowControl();
        tableLayoutPanel2 = new TableLayoutPanel();
        groupBox1 = new GroupBox();
        tableLayoutPanel3 = new TableLayoutPanel();
        connectCamera = new Button();
        connectPlc = new Button();
        displayLogs = new Button();
        takeGraphic = new Button();
        groupBox2 = new GroupBox();
        panel2 = new Panel();
        menuStrip1.SuspendLayout();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        groupBox1.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.GripStyle = ToolStripGripStyle.Visible;
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { projects });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1103, 28);
        menuStrip1.TabIndex = 1;
        menuStrip1.Text = "menuStrip1";
        // 
        // projects
        // 
        projects.DropDownItems.AddRange(new ToolStripItem[] { ninePointCalib });
        projects.Name = "projects";
        projects.Size = new Size(53, 24);
        projects.Text = "项目";
        // 
        // ninePointCalib
        // 
        ninePointCalib.Name = "ninePointCalib";
        ninePointCalib.Size = new Size(224, 26);
        ninePointCalib.Text = "九点标定";
        ninePointCalib.Click += ninePointCalib_Click;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(32, 19);
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new Size(32, 19);
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 28);
        panel1.Name = "panel1";
        panel1.Size = new Size(1103, 567);
        panel1.TabIndex = 2;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        tableLayoutPanel1.Controls.Add(hSmartWindowControl1, 1, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(1103, 567);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // hSmartWindowControl1
        // 
        hSmartWindowControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        hSmartWindowControl1.AutoValidate = AutoValidate.EnableAllowFocusChange;
        hSmartWindowControl1.Dock = DockStyle.Fill;
        hSmartWindowControl1.HDoubleClickToFitContent = true;
        hSmartWindowControl1.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
        hSmartWindowControl1.HImagePart = new Rectangle(-161, -25, 962, 529);
        hSmartWindowControl1.HKeepAspectRatio = true;
        hSmartWindowControl1.HMoveContent = true;
        hSmartWindowControl1.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
        hSmartWindowControl1.Location = new Point(330, 0);
        hSmartWindowControl1.Margin = new Padding(0);
        hSmartWindowControl1.Name = "hSmartWindowControl1";
        hSmartWindowControl1.Size = new Size(773, 567);
        hSmartWindowControl1.TabIndex = 0;
        hSmartWindowControl1.WindowSize = new Size(773, 567);
        hSmartWindowControl1.Load += hSmartWindowControl1_Load;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
        tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.333334F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 71.6666641F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel2.Size = new Size(324, 561);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(tableLayoutPanel3);
        groupBox1.Dock = DockStyle.Fill;
        groupBox1.Location = new Point(3, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(318, 152);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "程序操作";
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 2;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(connectCamera, 0, 0);
        tableLayoutPanel3.Controls.Add(connectPlc, 1, 0);
        tableLayoutPanel3.Controls.Add(displayLogs, 0, 1);
        tableLayoutPanel3.Controls.Add(takeGraphic, 1, 1);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(3, 23);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
        tableLayoutPanel3.Size = new Size(312, 126);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // connectCamera
        // 
        connectCamera.Dock = DockStyle.Fill;
        connectCamera.Location = new Point(3, 3);
        connectCamera.Name = "connectCamera";
        connectCamera.Size = new Size(150, 57);
        connectCamera.TabIndex = 0;
        connectCamera.Text = "连接相机";
        connectCamera.UseVisualStyleBackColor = true;
        connectCamera.Click += connectCamera_Click;
        // 
        // connectPlc
        // 
        connectPlc.Dock = DockStyle.Fill;
        connectPlc.Location = new Point(159, 3);
        connectPlc.Name = "connectPlc";
        connectPlc.Size = new Size(150, 57);
        connectPlc.TabIndex = 1;
        connectPlc.Text = "连接PLC";
        connectPlc.UseVisualStyleBackColor = true;
        connectPlc.Click += connectPlc_Click;
        // 
        // displayLogs
        // 
        displayLogs.Dock = DockStyle.Fill;
        displayLogs.Location = new Point(3, 66);
        displayLogs.Name = "displayLogs";
        displayLogs.Size = new Size(150, 57);
        displayLogs.TabIndex = 4;
        displayLogs.Text = "显示日志";
        displayLogs.UseVisualStyleBackColor = true;
        displayLogs.Click += displayLogs_Click;
        // 
        // takeGraphic
        // 
        takeGraphic.Dock = DockStyle.Fill;
        takeGraphic.Location = new Point(159, 66);
        takeGraphic.Name = "takeGraphic";
        takeGraphic.Size = new Size(150, 57);
        takeGraphic.TabIndex = 5;
        takeGraphic.Text = "拍照";
        takeGraphic.UseVisualStyleBackColor = true;
        takeGraphic.Click += takeGraphic_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(panel2);
        groupBox2.Dock = DockStyle.Fill;
        groupBox2.Location = new Point(3, 161);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(318, 397);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "项目配置";
        // 
        // panel2
        // 
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(3, 23);
        panel2.Name = "panel2";
        panel2.Size = new Size(312, 371);
        panel2.TabIndex = 0;
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1103, 595);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        MinimumSize = new Size(1121, 642);
        Name = "Main";
        Text = "Form1";
        Load += Main_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Button takeGraphic;

    private System.Windows.Forms.Button displayLogs;

    private System.Windows.Forms.Button connectPlc;

    private System.Windows.Forms.Button connectCamera;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private HalconDotNet.HSmartWindowControl hSmartWindowControl1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion

    private System.Windows.Forms.ToolStripMenuItem projects;
    private GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private ToolStripMenuItem ninePointCalib;
}