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
            this.main功能表 = new System.Windows.Forms.MenuStrip();
            this.main功能 = new System.Windows.Forms.ToolStripMenuItem();
            this.main開啟主選單 = new System.Windows.Forms.ToolStripMenuItem();
            this.main選項 = new System.Windows.Forms.ToolStripMenuItem();
            this.main分隔線 = new System.Windows.Forms.ToolStripSeparator();
            this.main關閉 = new System.Windows.Forms.ToolStripMenuItem();
            this.main工具 = new System.Windows.Forms.ToolStripMenuItem();
            this.main關於 = new System.Windows.Forms.ToolStripMenuItem();
            this.main功能表.SuspendLayout();
            this.SuspendLayout();
            // 
            // main功能表
            // 
            resources.ApplyResources(this.main功能表, "main功能表");
            this.main功能表.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.main功能表.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.main功能,
            this.main工具,
            this.main關於});
            this.main功能表.Name = "main功能表";
            // 
            // main功能
            // 
            resources.ApplyResources(this.main功能, "main功能");
            this.main功能.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.main開啟主選單,
            this.main選項,
            this.main分隔線,
            this.main關閉});
            this.main功能.Name = "main功能";
            // 
            // main開啟主選單
            // 
            resources.ApplyResources(this.main開啟主選單, "main開啟主選單");
            this.main開啟主選單.Name = "main開啟主選單";
            this.main開啟主選單.Click += new System.EventHandler(this.開啟主選單_Click);
            // 
            // main選項
            // 
            resources.ApplyResources(this.main選項, "main選項");
            this.main選項.Name = "main選項";
            this.main選項.Click += new System.EventHandler(this.選項_Click);
            // 
            // main分隔線
            // 
            resources.ApplyResources(this.main分隔線, "main分隔線");
            this.main分隔線.Name = "main分隔線";
            // 
            // main關閉
            // 
            resources.ApplyResources(this.main關閉, "main關閉");
            this.main關閉.Name = "main關閉";
            this.main關閉.Click += new System.EventHandler(this.關閉_Click);
            // 
            // main工具
            // 
            resources.ApplyResources(this.main工具, "main工具");
            this.main工具.Name = "main工具";
            // 
            // main關於
            // 
            resources.ApplyResources(this.main關於, "main關於");
            this.main關於.Name = "main關於";
            this.main關於.Click += new System.EventHandler(this.main關於_Click);
            // 
            // Minecraft指令生成器
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main功能表);
            this.MainMenuStrip = this.main功能表;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Minecraft指令生成器";
            this.main功能表.ResumeLayout(false);
            this.main功能表.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main功能表;
        private System.Windows.Forms.ToolStripMenuItem main功能;
        private System.Windows.Forms.ToolStripMenuItem main工具;
        private System.Windows.Forms.ToolStripMenuItem main開啟主選單;
        private System.Windows.Forms.ToolStripMenuItem main選項;
        private System.Windows.Forms.ToolStripSeparator main分隔線;
        private System.Windows.Forms.ToolStripMenuItem main關閉;
        private System.Windows.Forms.ToolStripMenuItem main關於;
    }
}

