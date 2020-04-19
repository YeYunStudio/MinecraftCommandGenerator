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
            this.NowLoadinng = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NowLoadinng
            // 
            resources.ApplyResources(this.NowLoadinng, "NowLoadinng");
            this.NowLoadinng.ForeColor = System.Drawing.Color.Orange;
            this.NowLoadinng.Name = "NowLoadinng";
            this.NowLoadinng.UseWaitCursor = true;
            // 
            // Minecraft指令生成器
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NowLoadinng);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Minecraft指令生成器";
            this.Load += new System.EventHandler(this.Minecraft指令生成器_Load);
            this.Shown += new System.EventHandler(this.Minecraft指令生成器_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NowLoadinng;
    }
}

