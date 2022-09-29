using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 控制板测试
{
    public partial class Form_worker_setting : Form
    {
        public Form_worker_setting()
        {
            InitializeComponent();
        }
        private void Form_worker_setting_Load(object sender, EventArgs e)
        {
            textBox1.Text = 系统设置TableAdapter.get当前测试班组();
            textBox2.Text = 系统设置TableAdapter.get当前测试人();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pcba_databaseDataSet.系统设置DataTable table1 = new pcba_databaseDataSet.系统设置DataTable();
            系统设置TableAdapter.set当前测试班组(table1 , textBox1.Text);
            系统设置TableAdapter.set当前测试人(textBox2.Text);
            MessageBox.Show("设置成功");
        }

      
    }
}
