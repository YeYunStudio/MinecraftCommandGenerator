using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void Minecraft指令生成器_Load(object sender, EventArgs e)
        {
            NowLoadinng.Show();
        }

        private void Minecraft指令生成器_Shown(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
