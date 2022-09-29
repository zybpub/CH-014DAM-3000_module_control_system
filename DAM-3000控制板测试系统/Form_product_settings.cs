using System;
using System.Windows.Forms;

namespace 控制板测试
{
    public partial class Form_product_settings : Form
    {
        public Form_product_settings()
        {
            InitializeComponent();
        }

        private void Form_product_settings_Load(object sender, EventArgs e)
        {
         
            

            // TODO: 这行代码将数据加载到表“pcba_databaseDataSet1.系统设置”中。您可以根据需要移动或删除它。
          //  this.系统设置TableAdapter.Fill(this.pcba_databaseDataSet1.系统设置);
            // TODO: 这行代码将数据加载到表“pcba_databaseDataSet.产品”中。您可以根据需要移动或删除它。
            this.产品TableAdapter.Fill(this.pcba_databaseDataSet.产品);
            // TODO: 这行代码将数据加载到表“pcba_databaseDataSet.产品”中。您可以根据需要移动或删除它。
            this.产品TableAdapter.Fill(this.pcba_databaseDataSet.产品);
            Disp_Current_Value();
        }

        //显示当前使用的产品信息
        private void Disp_Current_Value() {
            string id = 系统设置TableAdapter.Get当前产品id().ToString();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (dataGridView1.Rows[i].Cells["id"].Value.ToString() == id) //keyword要查的关键字
                {
                    dataGridView1.Rows[i].Selected = true;
                    this.dataGridView1.CurrentCell = this.dataGridView1.Rows[i].Cells[0];
                    break;
                }
            }

            pcba_databaseDataSet.产品DataTable table1 = new pcba_databaseDataSet.产品DataTable();

            产品TableAdapter.GetDataById(table1, Convert.ToInt16(id));

            lb_id.Text = table1.Rows[0][0].ToString();
            lb_name.Text = table1.Rows[0][1].ToString();
            lb_type.Text = table1.Rows[0][2].ToString();
            lb_require.Text = table1.Rows[0][3].ToString();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.产品TableAdapter.Fill(this.pcba_databaseDataSet.产品);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.产品TableAdapter.Update(pcba_databaseDataSet);
            MessageBox.Show("保存成功!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int16 id= Convert.ToInt16( dataGridView1.CurrentRow.Cells["id"].Value);
            dataGridView1.CurrentRow.Selected = true;
            this.系统设置TableAdapter.Update当前产品id(id);

            Disp_Current_Value();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save2_Click(object sender, EventArgs e)
        {
            if (tb_name.Text != "")
            {
                产品TableAdapter.Insert(tb_name.Text, tb_type.Text, tb_require.Text);
                this.产品TableAdapter.Fill(this.pcba_databaseDataSet.产品);
                dataGridView1.Refresh();
                Disp_Current_Value();
            }
        }
    }
}
