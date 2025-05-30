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
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        projects = new System.Windows.Forms.ToolStripMenuItem();
        ninePointCalib = new System.Windows.Forms.ToolStripMenuItem();
        measure = new System.Windows.Forms.ToolStripMenuItem();
        camera = new System.Windows.Forms.ToolStripMenuItem();
        cameraConfig = new System.Windows.Forms.ToolStripMenuItem();
        disconnectCamera = new System.Windows.Forms.ToolStripMenuItem();
        pLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        disconnectPlc = new System.Windows.Forms.ToolStripMenuItem();
        system = new System.Windows.Forms.ToolStripMenuItem();
        systemConfig = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        panel1 = new System.Windows.Forms.Panel();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        groupBox1 = new System.Windows.Forms.GroupBox();
        indicatorLight2 = new HalconCalibration.Views.IndicatorLight();
        indicatorLight1 = new HalconCalibration.Views.IndicatorLight();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        connectCamera = new System.Windows.Forms.Button();
        connectPlc = new System.Windows.Forms.Button();
        displayLogs = new System.Windows.Forms.Button();
        takeGraphic = new System.Windows.Forms.Button();
        groupBox2 = new System.Windows.Forms.GroupBox();
        panel2 = new System.Windows.Forms.Panel();
        panel3 = new System.Windows.Forms.Panel();
        groupBox3 = new System.Windows.Forms.GroupBox();
        hSmartWindowControl1 = new HalconDotNet.HSmartWindowControl();
        toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        groupBox1.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        groupBox2.SuspendLayout();
        panel3.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
        menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { projects, camera, pLCToolStripMenuItem, system });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(1103, 28);
        menuStrip1.TabIndex = 1;
        menuStrip1.Text = "menuStrip1";
        // 
        // projects
        // 
        projects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ninePointCalib, measure });
        projects.Name = "projects";
        projects.Size = new System.Drawing.Size(53, 24);
        projects.Text = "项目";
        // 
        // ninePointCalib
        // 
        ninePointCalib.Name = "ninePointCalib";
        ninePointCalib.Size = new System.Drawing.Size(224, 26);
        ninePointCalib.Text = "九点标定";
        ninePointCalib.Click += ninePointCalib_Click;
        // 
        // measure
        // 
        measure.Name = "measure";
        measure.Size = new System.Drawing.Size(224, 26);
        measure.Text = "尺寸测量";
        measure.Click += measure_Click;
        // 
        // camera
        // 
        camera.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cameraConfig, disconnectCamera });
        camera.Name = "camera";
        camera.Size = new System.Drawing.Size(53, 24);
        camera.Text = "相机";
        // 
        // cameraConfig
        // 
        cameraConfig.Name = "cameraConfig";
        cameraConfig.Size = new System.Drawing.Size(152, 26);
        cameraConfig.Text = "相机配置";
        // 
        // disconnectCamera
        // 
        disconnectCamera.Enabled = false;
        disconnectCamera.Name = "disconnectCamera";
        disconnectCamera.Size = new System.Drawing.Size(152, 26);
        disconnectCamera.Text = "断开相机";
        disconnectCamera.Click += disconnectCamera_Click;
        // 
        // pLCToolStripMenuItem
        // 
        pLCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { disconnectPlc });
        pLCToolStripMenuItem.Name = "pLCToolStripMenuItem";
        pLCToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
        pLCToolStripMenuItem.Text = "PLC";
        // 
        // disconnectPlc
        // 
        disconnectPlc.Enabled = false;
        disconnectPlc.Name = "disconnectPlc";
        disconnectPlc.Size = new System.Drawing.Size(224, 26);
        disconnectPlc.Text = "断开PLC";
        disconnectPlc.Click += disconnectPlc_Click;
        // 
        // system
        // 
        system.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { systemConfig });
        system.Name = "system";
        system.Size = new System.Drawing.Size(53, 24);
        system.Text = "系统";
        // 
        // systemConfig
        // 
        systemConfig.Name = "systemConfig";
        systemConfig.Size = new System.Drawing.Size(122, 26);
        systemConfig.Text = "配置";
        systemConfig.Click += systemConfig_Click;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 28);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1103, 567);
        panel1.TabIndex = 2;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(panel3, 1, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1103, 567);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
        tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.333334F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.666664F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.Size = new System.Drawing.Size(324, 561);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(indicatorLight2);
        groupBox1.Controls.Add(indicatorLight1);
        groupBox1.Controls.Add(tableLayoutPanel3);
        groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox1.Location = new System.Drawing.Point(3, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(318, 152);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "程序操作";
        // 
        // indicatorLight2
        // 
        indicatorLight2.IsOn = false;
        indicatorLight2.Location = new System.Drawing.Point(99, 0);
        indicatorLight2.Name = "indicatorLight2";
        indicatorLight2.OffColor = System.Drawing.Color.Gray;
        indicatorLight2.OnColor = System.Drawing.Color.LimeGreen;
        indicatorLight2.Size = new System.Drawing.Size(18, 21);
        indicatorLight2.TabIndex = 3;
        indicatorLight2.Text = "indicatorLight1";
        // 
        // indicatorLight1
        // 
        indicatorLight1.IsOn = false;
        indicatorLight1.Location = new System.Drawing.Point(75, 0);
        indicatorLight1.Name = "indicatorLight1";
        indicatorLight1.OffColor = System.Drawing.Color.Gray;
        indicatorLight1.OnColor = System.Drawing.Color.LimeGreen;
        indicatorLight1.Size = new System.Drawing.Size(18, 21);
        indicatorLight1.TabIndex = 3;
        indicatorLight1.Text = "indicatorLight1";
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 2;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(connectCamera, 0, 0);
        tableLayoutPanel3.Controls.Add(connectPlc, 1, 0);
        tableLayoutPanel3.Controls.Add(displayLogs, 0, 1);
        tableLayoutPanel3.Controls.Add(takeGraphic, 1, 1);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333336F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333336F));
        tableLayoutPanel3.Size = new System.Drawing.Size(312, 126);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // connectCamera
        // 
        connectCamera.Dock = System.Windows.Forms.DockStyle.Fill;
        connectCamera.Location = new System.Drawing.Point(3, 3);
        connectCamera.Name = "connectCamera";
        connectCamera.Size = new System.Drawing.Size(150, 57);
        connectCamera.TabIndex = 0;
        connectCamera.Text = "连接相机";
        connectCamera.UseVisualStyleBackColor = true;
        connectCamera.Click += connectCamera_Click;
        // 
        // connectPlc
        // 
        connectPlc.Dock = System.Windows.Forms.DockStyle.Fill;
        connectPlc.Location = new System.Drawing.Point(159, 3);
        connectPlc.Name = "connectPlc";
        connectPlc.Size = new System.Drawing.Size(150, 57);
        connectPlc.TabIndex = 1;
        connectPlc.Text = "连接PLC";
        connectPlc.UseVisualStyleBackColor = true;
        connectPlc.Click += connectPlc_Click;
        // 
        // displayLogs
        // 
        displayLogs.Dock = System.Windows.Forms.DockStyle.Fill;
        displayLogs.Location = new System.Drawing.Point(3, 66);
        displayLogs.Name = "displayLogs";
        displayLogs.Size = new System.Drawing.Size(150, 57);
        displayLogs.TabIndex = 4;
        displayLogs.Text = "显示日志";
        displayLogs.UseVisualStyleBackColor = true;
        displayLogs.Click += displayLogs_Click;
        // 
        // takeGraphic
        // 
        takeGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
        takeGraphic.Location = new System.Drawing.Point(159, 66);
        takeGraphic.Name = "takeGraphic";
        takeGraphic.Size = new System.Drawing.Size(150, 57);
        takeGraphic.TabIndex = 5;
        takeGraphic.Text = "拍照";
        takeGraphic.UseVisualStyleBackColor = true;
        takeGraphic.Click += takeGraphic_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(panel2);
        groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox2.Location = new System.Drawing.Point(3, 161);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(318, 397);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "项目配置";
        // 
        // panel2
        // 
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(3, 23);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(312, 371);
        panel2.TabIndex = 0;
        // 
        // panel3
        // 
        panel3.Controls.Add(groupBox3);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(333, 3);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(767, 561);
        panel3.TabIndex = 2;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(hSmartWindowControl1);
        groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox3.Location = new System.Drawing.Point(0, 0);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(767, 561);
        groupBox3.TabIndex = 0;
        groupBox3.TabStop = false;
        groupBox3.Text = "项目";
        // 
        // hSmartWindowControl1
        // 
        hSmartWindowControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        hSmartWindowControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
        hSmartWindowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        hSmartWindowControl1.HDoubleClickToFitContent = true;
        hSmartWindowControl1.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
        hSmartWindowControl1.HImagePart = new System.Drawing.Rectangle(-153, -10, 946, 499);
        hSmartWindowControl1.HKeepAspectRatio = true;
        hSmartWindowControl1.HMoveContent = true;
        hSmartWindowControl1.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
        hSmartWindowControl1.Location = new System.Drawing.Point(3, 23);
        hSmartWindowControl1.Margin = new System.Windows.Forms.Padding(0);
        hSmartWindowControl1.Name = "hSmartWindowControl1";
        hSmartWindowControl1.Size = new System.Drawing.Size(761, 535);
        hSmartWindowControl1.TabIndex = 0;
        hSmartWindowControl1.WindowSize = new System.Drawing.Size(761, 535);
        hSmartWindowControl1.Load += hSmartWindowControl1_Load;
        // 
        // toolStripMenuItem3
        // 
        toolStripMenuItem3.Name = "toolStripMenuItem3";
        toolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem4
        // 
        toolStripMenuItem4.Name = "toolStripMenuItem4";
        toolStripMenuItem4.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem5
        // 
        toolStripMenuItem5.Name = "toolStripMenuItem5";
        toolStripMenuItem5.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem6
        // 
        toolStripMenuItem6.Name = "toolStripMenuItem6";
        toolStripMenuItem6.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem7
        // 
        toolStripMenuItem7.Name = "toolStripMenuItem7";
        toolStripMenuItem7.Size = new System.Drawing.Size(32, 19);
        // 
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1103, 595);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        MinimumSize = new System.Drawing.Size(1121, 642);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form1";
        FormClosing += Main_FormClosing;
        Load += Main_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

    private System.Windows.Forms.GroupBox groupBox3;

    private System.Windows.Forms.Panel panel3;

    private HalconCalibration.Views.IndicatorLight indicatorLight2;

    private HalconCalibration.Views.IndicatorLight indicatorLight1;

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
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private ToolStripMenuItem ninePointCalib;
    private ToolStripMenuItem camera;
    private ToolStripMenuItem cameraConfig;
    private System.Windows.Forms.ToolStripMenuItem disconnectCamera;
    private ToolStripMenuItem pLCToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem disconnectPlc;
    private ToolStripMenuItem system;
    private ToolStripMenuItem systemConfig;
    private ToolStripMenuItem measure;
}