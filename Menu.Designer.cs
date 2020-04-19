namespace MinecraftCommandGenerator
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu開啟主選單 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu選項 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu分隔線 = new System.Windows.Forms.ToolStripSeparator();
            this.menu關閉 = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.關於ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu開啟主選單,
            this.menu選項,
            this.menu分隔線,
            this.menu關閉});
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.功能ToolStripMenuItem.Text = "功能";
            // 
            // menu開啟主選單
            // 
            this.menu開啟主選單.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu開啟主選單.Enabled = false;
            this.menu開啟主選單.Name = "menu開啟主選單";
            this.menu開啟主選單.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menu開啟主選單.Size = new System.Drawing.Size(220, 26);
            this.menu開啟主選單.Text = "開啟主選單";
            this.menu開啟主選單.Click += new System.EventHandler(this.menu開啟主選單_Click);
            // 
            // menu選項
            // 
            this.menu選項.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu選項.Name = "menu選項";
            this.menu選項.ShortcutKeyDisplayString = "Ctrl+,";
            this.menu選項.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma)));
            this.menu選項.Size = new System.Drawing.Size(220, 26);
            this.menu選項.Text = "選項";
            this.menu選項.Click += new System.EventHandler(this.menu選項_Click);
            // 
            // menu分隔線
            // 
            this.menu分隔線.Name = "menu分隔線";
            this.menu分隔線.Size = new System.Drawing.Size(217, 6);
            // 
            // menu關閉
            // 
            this.menu關閉.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu關閉.Name = "menu關閉";
            this.menu關閉.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menu關閉.Size = new System.Drawing.Size(220, 26);
            this.menu關閉.Text = "關閉";
            this.menu關閉.Click += new System.EventHandler(this.menu關閉_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.關於ToolStripMenuItem.Text = "關於";
            this.關於ToolStripMenuItem.Click += new System.EventHandler(this.關於ToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu開啟主選單;
        private System.Windows.Forms.ToolStripMenuItem menu選項;
        private System.Windows.Forms.ToolStripSeparator menu分隔線;
        private System.Windows.Forms.ToolStripMenuItem menu關閉;
    }
}