﻿namespace IoTClient.Tool
{
    partial class IndexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SiemensS7200 = new System.Windows.Forms.TabPage();
            this.SiemensS7200Smart = new System.Windows.Forms.TabPage();
            this.SiemensS7300 = new System.Windows.Forms.TabPage();
            this.SiemensS7400 = new System.Windows.Forms.TabPage();
            this.SiemensS71200 = new System.Windows.Forms.TabPage();
            this.SiemensS71500 = new System.Windows.Forms.TabPage();
            this.MitsubishiMC = new System.Windows.Forms.TabPage();
            this.OmronFinsTcp = new System.Windows.Forms.TabPage();
            this.BACnet = new System.Windows.Forms.TabPage();
            this.MQTT = new System.Windows.Forms.TabPage();
            this.Ports = new System.Windows.Forms.TabPage();
            this.Other = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBlogPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.商务合作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ModBusAscii = new System.Windows.Forms.TabPage();
            this.ModBusRtu = new System.Windows.Forms.TabPage();
            this.modBusTcpControl1 = new IoTClient.Tool.ModBusTcpControl();
            this.ModBusTcp = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ModBusTcp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ModBusTcp);
            this.tabControl1.Controls.Add(this.ModBusRtu);
            this.tabControl1.Controls.Add(this.ModBusAscii);
            this.tabControl1.Controls.Add(this.SiemensS7200);
            this.tabControl1.Controls.Add(this.SiemensS7200Smart);
            this.tabControl1.Controls.Add(this.SiemensS7300);
            this.tabControl1.Controls.Add(this.SiemensS7400);
            this.tabControl1.Controls.Add(this.SiemensS71200);
            this.tabControl1.Controls.Add(this.SiemensS71500);
            this.tabControl1.Controls.Add(this.MitsubishiMC);
            this.tabControl1.Controls.Add(this.OmronFinsTcp);
            this.tabControl1.Controls.Add(this.BACnet);
            this.tabControl1.Controls.Add(this.MQTT);
            this.tabControl1.Controls.Add(this.Ports);
            this.tabControl1.Controls.Add(this.Other);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1192, 592);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // SiemensS7200
            // 
            this.SiemensS7200.Location = new System.Drawing.Point(4, 25);
            this.SiemensS7200.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SiemensS7200.Name = "SiemensS7200";
            this.SiemensS7200.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SiemensS7200.Size = new System.Drawing.Size(1184, 563);
            this.SiemensS7200.TabIndex = 10;
            this.SiemensS7200.Text = "S7-200";
            this.SiemensS7200.UseVisualStyleBackColor = true;
            // 
            // SiemensS7200Smart
            // 
            this.SiemensS7200Smart.Location = new System.Drawing.Point(4, 25);
            this.SiemensS7200Smart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SiemensS7200Smart.Name = "SiemensS7200Smart";
            this.SiemensS7200Smart.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SiemensS7200Smart.Size = new System.Drawing.Size(1184, 563);
            this.SiemensS7200Smart.TabIndex = 1;
            this.SiemensS7200Smart.Text = "S7-200Smart";
            this.SiemensS7200Smart.UseVisualStyleBackColor = true;
            // 
            // SiemensS7300
            // 
            this.SiemensS7300.Location = new System.Drawing.Point(4, 25);
            this.SiemensS7300.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SiemensS7300.Name = "SiemensS7300";
            this.SiemensS7300.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SiemensS7300.Size = new System.Drawing.Size(1184, 563);
            this.SiemensS7300.TabIndex = 8;
            this.SiemensS7300.Text = "S7-300";
            this.SiemensS7300.UseVisualStyleBackColor = true;
            // 
            // SiemensS7400
            // 
            this.SiemensS7400.Location = new System.Drawing.Point(4, 25);
            this.SiemensS7400.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SiemensS7400.Name = "SiemensS7400";
            this.SiemensS7400.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SiemensS7400.Size = new System.Drawing.Size(1184, 563);
            this.SiemensS7400.TabIndex = 8;
            this.SiemensS7400.Text = "S7-400";
            this.SiemensS7400.UseVisualStyleBackColor = true;
            // 
            // SiemensS71200
            // 
            this.SiemensS71200.Location = new System.Drawing.Point(4, 25);
            this.SiemensS71200.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SiemensS71200.Name = "SiemensS71200";
            this.SiemensS71200.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SiemensS71200.Size = new System.Drawing.Size(1184, 563);
            this.SiemensS71200.TabIndex = 8;
            this.SiemensS71200.Text = "S7-1200";
            this.SiemensS71200.UseVisualStyleBackColor = true;
            // 
            // SiemensS71500
            // 
            this.SiemensS71500.Location = new System.Drawing.Point(4, 25);
            this.SiemensS71500.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SiemensS71500.Name = "SiemensS71500";
            this.SiemensS71500.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SiemensS71500.Size = new System.Drawing.Size(1184, 563);
            this.SiemensS71500.TabIndex = 8;
            this.SiemensS71500.Text = "S7-1500";
            this.SiemensS71500.UseVisualStyleBackColor = true;
            // 
            // MitsubishiMC
            // 
            this.MitsubishiMC.Location = new System.Drawing.Point(4, 25);
            this.MitsubishiMC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MitsubishiMC.Name = "MitsubishiMC";
            this.MitsubishiMC.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MitsubishiMC.Size = new System.Drawing.Size(1184, 563);
            this.MitsubishiMC.TabIndex = 5;
            this.MitsubishiMC.Text = " 三菱MC Beta";
            this.MitsubishiMC.UseVisualStyleBackColor = true;
            // 
            // OmronFinsTcp
            // 
            this.OmronFinsTcp.Location = new System.Drawing.Point(4, 25);
            this.OmronFinsTcp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OmronFinsTcp.Name = "OmronFinsTcp";
            this.OmronFinsTcp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OmronFinsTcp.Size = new System.Drawing.Size(1184, 563);
            this.OmronFinsTcp.TabIndex = 6;
            this.OmronFinsTcp.Text = "欧姆龙FinsTcp Beta";
            this.OmronFinsTcp.UseVisualStyleBackColor = true;
            // 
            // BACnet
            // 
            this.BACnet.Location = new System.Drawing.Point(4, 25);
            this.BACnet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BACnet.Name = "BACnet";
            this.BACnet.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BACnet.Size = new System.Drawing.Size(1184, 563);
            this.BACnet.TabIndex = 2;
            this.BACnet.Text = " BACnet ";
            this.BACnet.UseVisualStyleBackColor = true;
            // 
            // MQTT
            // 
            this.MQTT.Location = new System.Drawing.Point(4, 25);
            this.MQTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MQTT.Name = "MQTT";
            this.MQTT.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MQTT.Size = new System.Drawing.Size(1184, 563);
            this.MQTT.TabIndex = 11;
            this.MQTT.Text = "MQTT";
            this.MQTT.UseVisualStyleBackColor = true;
            // 
            // Ports
            // 
            this.Ports.Location = new System.Drawing.Point(4, 25);
            this.Ports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ports.Name = "Ports";
            this.Ports.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ports.Size = new System.Drawing.Size(1184, 563);
            this.Ports.TabIndex = 3;
            this.Ports.Text = "  串口  ";
            this.Ports.UseVisualStyleBackColor = true;
            // 
            // Other
            // 
            this.Other.Location = new System.Drawing.Point(4, 25);
            this.Other.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Other.Name = "Other";
            this.Other.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Other.Size = new System.Drawing.Size(1184, 563);
            this.Other.TabIndex = 9;
            this.Other.Text = "工具";
            this.Other.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItemBlogPath,
            this.toolStripMenuItem4,
            this.商务合作ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1192, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(128, 24);
            this.toolStripMenuItem5.Text = "擎呐设备云平台";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem2.Text = "开源地址";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItem3.Text = "提交Bug";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItemBlogPath
            // 
            this.toolStripMenuItemBlogPath.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemBlogPath.Name = "toolStripMenuItemBlogPath";
            this.toolStripMenuItemBlogPath.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItemBlogPath.Text = "博客地址";
            this.toolStripMenuItemBlogPath.Click += new System.EventHandler(this.toolStripMenuItemBlogPath_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(68, 24);
            this.toolStripMenuItem4.Text = "交流群";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // 商务合作ToolStripMenuItem
            // 
            this.商务合作ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.商务合作ToolStripMenuItem.Name = "商务合作ToolStripMenuItem";
            this.商务合作ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.商务合作ToolStripMenuItem.Text = "商务合作";
            this.商务合作ToolStripMenuItem.Click += new System.EventHandler(this.cooperationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 24);
            this.toolStripMenuItem1.Text = "检查更新  V0.4.0";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ModBusAscii
            // 
            this.ModBusAscii.Location = new System.Drawing.Point(4, 25);
            this.ModBusAscii.Margin = new System.Windows.Forms.Padding(4);
            this.ModBusAscii.Name = "ModBusAscii";
            this.ModBusAscii.Padding = new System.Windows.Forms.Padding(4);
            this.ModBusAscii.Size = new System.Drawing.Size(1184, 563);
            this.ModBusAscii.TabIndex = 7;
            this.ModBusAscii.Text = "ModBusAscii";
            this.ModBusAscii.UseVisualStyleBackColor = true;
            // 
            // ModBusRtu
            // 
            this.ModBusRtu.Location = new System.Drawing.Point(4, 25);
            this.ModBusRtu.Margin = new System.Windows.Forms.Padding(4);
            this.ModBusRtu.Name = "ModBusRtu";
            this.ModBusRtu.Padding = new System.Windows.Forms.Padding(4);
            this.ModBusRtu.Size = new System.Drawing.Size(1184, 563);
            this.ModBusRtu.TabIndex = 4;
            this.ModBusRtu.Text = "ModBusRtu";
            this.ModBusRtu.UseVisualStyleBackColor = true;
            // 
            // modBusTcpControl1
            // 
            this.modBusTcpControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modBusTcpControl1.Location = new System.Drawing.Point(4, 4);
            this.modBusTcpControl1.Margin = new System.Windows.Forms.Padding(5);
            this.modBusTcpControl1.Name = "modBusTcpControl1";
            this.modBusTcpControl1.Size = new System.Drawing.Size(1176, 555);
            this.modBusTcpControl1.TabIndex = 0;
            // 
            // ModBusTcp
            // 
            this.ModBusTcp.Controls.Add(this.modBusTcpControl1);
            this.ModBusTcp.Location = new System.Drawing.Point(4, 25);
            this.ModBusTcp.Margin = new System.Windows.Forms.Padding(4);
            this.ModBusTcp.Name = "ModBusTcp";
            this.ModBusTcp.Padding = new System.Windows.Forms.Padding(4);
            this.ModBusTcp.Size = new System.Drawing.Size(1184, 563);
            this.ModBusTcp.TabIndex = 0;
            this.ModBusTcp.Text = "ModBusTcp";
            this.ModBusTcp.UseVisualStyleBackColor = true;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 626);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "IndexForm";
            this.Text = "IoTClient Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IndexForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ModBusTcp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SiemensS7200Smart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBlogPath;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.TabPage BACnet;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.TabPage Ports;
        private System.Windows.Forms.TabPage MitsubishiMC;
        private System.Windows.Forms.TabPage OmronFinsTcp;
        private System.Windows.Forms.TabPage SiemensS7300;
        private System.Windows.Forms.TabPage SiemensS7400;
        private System.Windows.Forms.TabPage SiemensS71200;
        private System.Windows.Forms.TabPage SiemensS71500;
        private System.Windows.Forms.TabPage Other;
        private System.Windows.Forms.ToolStripMenuItem 商务合作ToolStripMenuItem;
        private System.Windows.Forms.TabPage SiemensS7200;
        private System.Windows.Forms.TabPage MQTT;
        private System.Windows.Forms.TabPage ModBusTcp;
        private ModBusTcpControl modBusTcpControl1;
        private System.Windows.Forms.TabPage ModBusRtu;
        private System.Windows.Forms.TabPage ModBusAscii;
    }
}