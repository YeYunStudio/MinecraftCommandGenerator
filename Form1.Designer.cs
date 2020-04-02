namespace MinecraftCommandGenerator
{
    partial class Minecraft指令生成器
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minecraft指令生成器));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.功能 = new System.Windows.Forms.ToolStripMenuItem();
            this.工具 = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟主選單 = new System.Windows.Forms.ToolStripMenuItem();
            this.選項 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.關閉 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能,
            this.工具});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 功能
            // 
            resources.ApplyResources(this.功能, "功能");
            this.功能.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟主選單,
            this.選項,
            this.toolStripSeparator1,
            this.關閉});
            this.功能.Name = "功能";
            // 
            // 工具
            // 
            resources.ApplyResources(this.工具, "工具");
            this.工具.Name = "工具";
            // 
            // 開啟主選單
            // 
            resources.ApplyResources(this.開啟主選單, "開啟主選單");
            this.開啟主選單.Name = "開啟主選單";
            this.開啟主選單.Click += new System.EventHandler(this.開啟主選單_Click);
            // 
            // 選項
            // 
            resources.ApplyResources(this.選項, "選項");
            this.選項.Name = "選項";
            this.選項.Click += new System.EventHandler(this.選項_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // 關閉
            // 
            resources.ApplyResources(this.關閉, "關閉");
            this.關閉.Name = "關閉";
            this.關閉.Click += new System.EventHandler(this.關閉_Click);
            // 
            // Minecraft指令生成器
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Minecraft指令生成器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 功能;
        private System.Windows.Forms.ToolStripMenuItem 工具;
        private System.Windows.Forms.ToolStripMenuItem 開啟主選單;
        private System.Windows.Forms.ToolStripMenuItem 選項;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 關閉;
    }
}

