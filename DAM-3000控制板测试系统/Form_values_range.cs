using System;
using System.Windows.Forms;

namespace 控制板测试
{
    public partial class Form_values_range : Form
    {
        public Form_values_range()
        {
            InitializeComponent();
        }

        Int16 产品id;
        private void Form_values_range_Load(object sender, EventArgs e)
        {
            //获取当前产品id
            pcba_databaseDataSetTableAdapters.系统设置TableAdapter table_sys = new pcba_databaseDataSetTableAdapters.系统设置TableAdapter();
            产品id =Convert.ToInt16( table_sys.Get当前产品id());

            // TODO: 这行代码将数据加载到表“pcba_databaseDataSet.产品测量值合格范围”中。您可以根据需要移动或删除它。
            this.产品测量值合格范围TableAdapter.Fill(this.pcba_databaseDataSet.产品测量值合格范围, 产品id);
            if (pcba_databaseDataSet.产品测量值合格范围.Rows.Count == 0)
            {
                产品测量值合格范围TableAdapter.Insert(产品id, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }
            else {
                tb_t1min.Text = this.pcba_databaseDataSet.产品测量值合格范围.Rows[0]["t1min"].ToString();
                tb_t2min.Text = this.pcba_databaseDataSet.产品测量值合格范围.Rows[0]["t2min"].ToString();
                tb_t3min.Text = this.pcba_databaseDataSet.产品测量值合格范围.Rows[0]["t3min"].ToString();
                tb_t4min.Text = this.pcba_databaseDataSet.产品测量值合格范围.Rows[0]["t4min"].ToString();
                tb_t5min.Text = this.pcba_databaseDataSet.产品测量值合格范围.Rows[0]["t5min"].ToString();
                tb_t6min.Text = this.pcba_databaseDataSet.产品测量值合格范围.Rows[0]["t6min"].ToString();

                tb_t1max.Text = this.pcba_databaseDataSet.产品测量值合格范围.Rows[0]["t1max"].ToString();
                tb_t2max.Text = this.pcba_databaseDataSet.产品测量值合格范围.Rows[0]["t2max"].ToString();
                tb_t3max.Text = this.pcba_databaseDataSet.产品测量值合格范围.Rows[0]["t3max"].ToString();
                tb_t4max.Text = this.pcba_databaseDataSet.产品测量值合格范围.Rows[0]["t4max"].ToString();
                tb_t5max.Text = this.pcba_databaseDataSet.产品测量值合格范围.Rows[0]["t5max"].ToString();
                tb_t6max.Text = this.pcba_databaseDataSet.产品测量值合格范围.Rows[0]["t6max"].ToString();
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

          Int16 范围id=Convert.ToInt16(  this.产品测量值合格范围TableAdapter.ScalarQuery产品id2范围id(产品id));


            try
            {
                this.产品测量值合格范围TableAdapter.UpdateQuery(
                   产品id,
                  Convert.ToDecimal(tb_t1min.Text),
                  Convert.ToDecimal(tb_t1max.Text),
                    Convert.ToDecimal(tb_t2min.Text),
                    Convert.ToDecimal(tb_t2max.Text),
                    Convert.ToDecimal(tb_t3min.Text),
                    Convert.ToDecimal(tb_t3max.Text),
                   Convert.ToDecimal(tb_t4min.Text),
                   Convert.ToDecimal(tb_t4max.Text),
                   Convert.ToDecimal(tb_t5min.Text),
                   Convert.ToDecimal(tb_t5max.Text),
                   Convert.ToDecimal(tb_t6min.Text),
                   Convert.ToDecimal(tb_t6max.Text),
                   范围id);
                MessageBox.Show("保存成功！");
            }
            catch {
                MessageBox.Show("输入数据有误，不能输入字母和留空！");
            }
        }

       
    }
}
