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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menu開啟主選單_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您已開啟主選單", "提示");
        }

        private void menu選項_Click(object sender, EventArgs e)
        {
            MessageBox.Show("選項功能製作中", "提示");
        }

        private void menu關閉_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Close();
        }
    }
}
