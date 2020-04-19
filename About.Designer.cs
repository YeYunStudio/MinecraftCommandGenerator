namespace MinecraftCommandGenerator
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.Aboutmenu = new System.Windows.Forms.MenuStrip();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟主選單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.關閉視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About程式名 = new System.Windows.Forms.Label();
            this.About版本資訊 = new System.Windows.Forms.Label();
            this.AboutThanks = new System.Windows.Forms.Label();
            this.AboutThankLink = new System.Windows.Forms.LinkLabel();
            this.AboutProgrammer = new System.Windows.Forms.Label();
            this.AboutDesigner = new System.Windows.Forms.Label();
            this.AboutCopyright = new System.Windows.Forms.Label();
            this.Aboutmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aboutmenu
            // 
            this.Aboutmenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Aboutmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.關於ToolStripMenuItem});
            this.Aboutmenu.Location = new System.Drawing.Point(0, 0);
            this.Aboutmenu.Name = "Aboutmenu";
            this.Aboutmenu.Size = new System.Drawing.Size(582, 27);
            this.Aboutmenu.TabIndex = 0;
            this.Aboutmenu.Text = "Aboutmenu";
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟主選單ToolStripMenuItem,
            this.選項ToolStripMenuItem,
            this.toolStripSeparator1,
            this.關閉視窗ToolStripMenuItem});
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.功能ToolStripMenuItem.Text = "功能";
            // 
            // 開啟主選單ToolStripMenuItem
            // 
            this.開啟主選單ToolStripMenuItem.Name = "開啟主選單ToolStripMenuItem";
            this.開啟主選單ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.開啟主選單ToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.開啟主選單ToolStripMenuItem.Text = "開啟主選單";
            this.開啟主選單ToolStripMenuItem.Click += new System.EventHandler(this.開啟主選單ToolStripMenuItem_Click);
            // 
            // 選項ToolStripMenuItem
            // 
            this.選項ToolStripMenuItem.Name = "選項ToolStripMenuItem";
            this.選項ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+,";
            this.選項ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma)));
            this.選項ToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.選項ToolStripMenuItem.Text = "選項";
            this.選項ToolStripMenuItem.Click += new System.EventHandler(this.選項ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // 關閉視窗ToolStripMenuItem
            // 
            this.關閉視窗ToolStripMenuItem.Name = "關閉視窗ToolStripMenuItem";
            this.關閉視窗ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.關閉視窗ToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.關閉視窗ToolStripMenuItem.Text = "關閉視窗";
            this.關閉視窗ToolStripMenuItem.Click += new System.EventHandler(this.關閉視窗ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.Enabled = false;
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.關於ToolStripMenuItem.Text = "關於";
            // 
            // About程式名
            // 
            this.About程式名.AutoSize = true;
            this.About程式名.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.About程式名.Location = new System.Drawing.Point(3, 30);
            this.About程式名.Name = "About程式名";
            this.About程式名.Size = new System.Drawing.Size(311, 34);
            this.About程式名.TabIndex = 2;
            this.About程式名.Text = "Minecraft指令生成器";
            // 
            // About版本資訊
            // 
            this.About版本資訊.AutoSize = true;
            this.About版本資訊.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.About版本資訊.Location = new System.Drawing.Point(12, 64);
            this.About版本資訊.Name = "About版本資訊";
            this.About版本資訊.Size = new System.Drawing.Size(193, 25);
            this.About版本資訊.TabIndex = 3;
            this.About版本資訊.Text = "版本：Alpha v0.1";
            // 
            // AboutThanks
            // 
            this.AboutThanks.AutoSize = true;
            this.AboutThanks.Font = new System.Drawing.Font("新細明體", 10F);
            this.AboutThanks.Location = new System.Drawing.Point(9, 93);
            this.AboutThanks.Name = "AboutThanks";
            this.AboutThanks.Size = new System.Drawing.Size(93, 17);
            this.AboutThanks.TabIndex = 4;
            this.AboutThanks.Text = "技術指導：";
            // 
            // AboutThankLink
            // 
            this.AboutThankLink.AutoSize = true;
            this.AboutThankLink.Font = new System.Drawing.Font("新細明體", 10F);
            this.AboutThankLink.Location = new System.Drawing.Point(94, 93);
            this.AboutThankLink.Name = "AboutThankLink";
            this.AboutThankLink.Size = new System.Drawing.Size(164, 17);
            this.AboutThankLink.TabIndex = 5;
            this.AboutThankLink.TabStop = true;
            this.AboutThankLink.Text = "魚丸o蕾娜-RenaWevin";
            this.AboutThankLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutThankLink_LinkClicked);
            // 
            // AboutProgrammer
            // 
            this.AboutProgrammer.AutoSize = true;
            this.AboutProgrammer.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AboutProgrammer.Location = new System.Drawing.Point(9, 114);
            this.AboutProgrammer.Name = "AboutProgrammer";
            this.AboutProgrammer.Size = new System.Drawing.Size(161, 17);
            this.AboutProgrammer.TabIndex = 6;
            this.AboutProgrammer.Text = "程式製作：ユキ綾乃";
            // 
            // AboutDesigner
            // 
            this.AboutDesigner.AutoSize = true;
            this.AboutDesigner.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AboutDesigner.Location = new System.Drawing.Point(9, 135);
            this.AboutDesigner.Name = "AboutDesigner";
            this.AboutDesigner.Size = new System.Drawing.Size(127, 17);
            this.AboutDesigner.TabIndex = 7;
            this.AboutDesigner.Text = "介面設計：夜娜";
            // 
            // AboutCopyright
            // 
            this.AboutCopyright.AutoSize = true;
            this.AboutCopyright.Font = new System.Drawing.Font("新細明體", 20F);
            this.AboutCopyright.Location = new System.Drawing.Point(168, 485);
            this.AboutCopyright.Margin = new System.Windows.Forms.Padding(0);
            this.AboutCopyright.Name = "AboutCopyright";
            this.AboutCopyright.Size = new System.Drawing.Size(414, 68);
            this.AboutCopyright.TabIndex = 8;
            this.AboutCopyright.Text = "Copyright ©2020夜雲工作室\r\nAll rights reserved";
            this.AboutCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.AboutCopyright);
            this.Controls.Add(this.AboutDesigner);
            this.Controls.Add(this.AboutProgrammer);
            this.Controls.Add(this.AboutThankLink);
            this.Controls.Add(this.AboutThanks);
            this.Controls.Add(this.About版本資訊);
            this.Controls.Add(this.About程式名);
            this.Controls.Add(this.Aboutmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Aboutmenu;
            this.Name = "About";
            this.Text = "About";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.About_FormClosed);
            this.Aboutmenu.ResumeLayout(false);
            this.Aboutmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Aboutmenu;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟主選單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 選項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 關閉視窗ToolStripMenuItem;
        private System.Windows.Forms.Label About程式名;
        private System.Windows.Forms.Label About版本資訊;
        private System.Windows.Forms.Label AboutThanks;
        private System.Windows.Forms.LinkLabel AboutThankLink;
        private System.Windows.Forms.Label AboutProgrammer;
        private System.Windows.Forms.Label AboutDesigner;
        private System.Windows.Forms.Label AboutCopyright;
    }
}