using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftCommandGenerator
{
    public partial class Minecraft指令生成器 : Form
    {
        public Minecraft指令生成器()
        {
            InitializeComponent();
        }

        private void 開啟主選單_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您已開啟主選單","提示");
        }

        private void 選項_Click(object sender, EventArgs e)
        {
            MessageBox.Show("選項功能製作中","提示");
        }

        private void 關閉_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main關於_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
