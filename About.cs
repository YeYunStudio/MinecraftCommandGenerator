﻿using System;
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

        private void 開啟主選單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void 選項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("選項功能製作中", "提示");
        }

        private void 關閉視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutThankLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/RenaWevin/");
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
