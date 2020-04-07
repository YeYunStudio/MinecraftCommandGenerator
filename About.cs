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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void 關閉視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Minecraft指令生成器 main = new Minecraft指令生成器();
            main.WindowState = FormWindowState.Normal;
            Application.Restore;
        }

        private void 選項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("選項功能製作中", "提示");
        }
    }
}
