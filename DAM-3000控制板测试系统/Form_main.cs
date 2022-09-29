using System;
using System.Windows.Forms;

namespace 控制板测试
{
    //直流电源：IT6833 72V3A
    public partial class Form_main : Form
    {
        Int16 产品id;
        public Form_main()
        {
            InitializeComponent();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
           
            //获取当前产品id
            pcba_databaseDataSetTableAdapters.系统设置TableAdapter table_sys = new pcba_databaseDataSetTableAdapters.系统设置TableAdapter();

            global_values.产品id = Convert.ToInt16(table_sys.Get当前产品id());
            global_values.当前测试班组 = table_sys.get当前测试班组();
            global_values.当前测试人=table_sys.get当前测试人();

            // TODO: 这行代码将数据加载到表“pcba_databaseDataSet.产品测试数据”中。您可以根据需要移动或删除它。
            this.产品测试数据TableAdapter.Fillb产品id(this.pcba_databaseDataSet.产品测试数据, 产品id);


            pcba_databaseDataSet.产品测量值合格范围DataTable table_合格范围 = new pcba_databaseDataSet.产品测量值合格范围DataTable();
            产品测量值合格范围TableAdapter.Fill(table_合格范围, global_values.产品id);
            lb_t1min.Text = table_合格范围.Rows[0]["t1min"].ToString();
            lb_t2min.Text = table_合格范围.Rows[0]["t2min"].ToString();
            lb_t3min.Text = table_合格范围.Rows[0]["t3min"].ToString();
            lb_t4min.Text = table_合格范围.Rows[0]["t4min"].ToString();
            lb_t5min.Text = table_合格范围.Rows[0]["t5min"].ToString();
            lb_t6min.Text = table_合格范围.Rows[0]["t6min"].ToString();

            lb_t1max.Text = table_合格范围.Rows[0]["t1max"].ToString();
            lb_t2max.Text = table_合格范围.Rows[0]["t2max"].ToString();
            lb_t3max.Text = table_合格范围.Rows[0]["t3max"].ToString();
            lb_t4max.Text = table_合格范围.Rows[0]["t4max"].ToString();
            lb_t5max.Text = table_合格范围.Rows[0]["t5max"].ToString();
            lb_t6max.Text = table_合格范围.Rows[0]["t6max"].ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {

                System.IO.StreamReader sr = new System.IO.StreamReader("barcode.txt");
                serialPort1.PortName = sr.ReadLine();
                serialPort1.BaudRate =Convert.ToInt16( sr.ReadLine());
                serialPort1.DataBits = Convert.ToInt16(sr.ReadLine());
               // serialPort1.StopBits = Convert.ToInt16(sr.ReadLine());
               //serialPort1.Parity = System.IO.Ports.Parity.None;
                if (serialPort1.IsOpen)    //当前为打开，则进行关闭处理
                {
                    serialPort1.Close();
                    btn_start.Text = "&O打开端口";
                }
                else     //当前为关闭，则进行打开处理
                {

                    btn_start.Text = "&C关闭端口";
  
                    serialPort1.Open();
   
                }
            }
            catch (Exception er)
            { MessageBox.Show("端口打开失败！" + er.Message, "提示"); }


        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           
            Invoke
             (new EventHandler
               (delegate
               {
                   if (tb_barcode.Text=="")
                   tb_barcode.Text += serialPort1.ReadExisting().ToString();
                   else
                       serialPort1.ReadExisting().ToString();
               }
               )
              );

        }

        private void btn_barcode_clear_Click(object sender, EventArgs e)
        {
            tb_barcode.Text = "";
        }

        private void btn_poweroff_Click(object sender, EventArgs e)
        {
            tb_barcode.Text = "";
        }

        private void 直流电源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_power_test pt = new Form_power_test();
            pt.ShowDialog();
        }

        private void 数字多用表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DM3058E dm = new Form_DM3058E();
           // Form_multimeter dm = new Form_multimeter();
            dm.ShowDialog();
        }

        private void 示波器测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_oscilloscope osc = new Form_oscilloscope();
            osc.ShowDialog();
        }

        private void 数据采集DM3053ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_dam_3053 fd3053 = new Form_dam_3053();
            fd3053.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AB = new AboutBox1();
            AB.ShowDialog();
        }

        private void 数字多用表测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_multimeter fm = new Form_multimeter();
            fm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_dam_3059 fd3059 = new Form_dam_3059();
            fd3059.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form_dam_3070 fd3070 = new Form_dam_3070();
            fd3070.ShowDialog();
        }

        private void 输出2014DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_dam_3014D fd3014d = new Form_dam_3014D();
            fd3014d.ShowDialog();
        }

        private void 输入3011DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_dam_3011D fd3011d = new Form_dam_3011D();
            fd3011d.ShowDialog();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_settings fs = new Form_settings();
            fs.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tb_barcode.Text == "") {
                MessageBox.Show("条形码不能为空！");
                return;
            }
            if (tb_t1.Text.Trim() == "" || tb_t1.Text.Trim() == "" || tb_t1.Text.Trim() == "" || tb_t1.Text.Trim() == "" || tb_t1.Text.Trim() == ""
                || tb_t1.Text.Trim() == "" || tb_t1.Text.Trim() == "") {
                MessageBox.Show("数据不能为空！");
                return;
            }

            //根据产品id获取合格范围
            pcba_databaseDataSet.产品测量值合格范围DataTable table_合格范围 = new pcba_databaseDataSet.产品测量值合格范围DataTable();
            产品测量值合格范围TableAdapter.Fill(table_合格范围, global_values.产品id);
            decimal t1min=  Convert.ToDecimal(table_合格范围.Rows[0]["t1min"]);
            decimal t2min = Convert.ToDecimal(table_合格范围.Rows[0]["t2min"]);
            decimal t3min = Convert.ToDecimal(table_合格范围.Rows[0]["t3min"]);
            decimal t4min = Convert.ToDecimal(table_合格范围.Rows[0]["t4min"]);
            decimal t5min = Convert.ToDecimal(table_合格范围.Rows[0]["t5min"]);
            decimal t6min = Convert.ToDecimal(table_合格范围.Rows[0]["t6min"]);

            decimal t1max = Convert.ToDecimal(table_合格范围.Rows[0]["t1max"]);
            decimal t2max = Convert.ToDecimal(table_合格范围.Rows[0]["t2max"]);
            decimal t3max = Convert.ToDecimal(table_合格范围.Rows[0]["t3max"]);
            decimal t4max = Convert.ToDecimal(table_合格范围.Rows[0]["t4max"]);
            decimal t5max = Convert.ToDecimal(table_合格范围.Rows[0]["t5max"]);
            decimal t6max = Convert.ToDecimal(table_合格范围.Rows[0]["t6max"]);

            decimal t1 = Convert.ToDecimal(tb_t1.Text);
            decimal t2 = Convert.ToDecimal(tb_t2.Text);
            decimal t3 = Convert.ToDecimal(tb_t3.Text);
            decimal t4 = Convert.ToDecimal(tb_t4.Text);
            decimal t5 = Convert.ToDecimal(tb_t5.Text);
            decimal t6 = Convert.ToDecimal(tb_t6.Text);

            bool b_t1 = false;
            bool b_t2 = false;
            bool b_t3 = false;
            bool b_t4 = false;
            bool b_t5 = false;
            bool b_t6 = false;

            if (t1 >= t1min && t1 <= t1max) b_t1 = true;
            if (t2 >= t2min && t2 <= t2max) b_t2 = true;
            if (t3 >= t3min && t3 <= t3max) b_t3 = true;
            if (t4 >= t4min && t4 <= t4max) b_t4 = true;
            if (t5 >= t5min && t5 <= t5max) b_t5 = true;
            if (t6 >= t6min && t6 <= t6max) b_t6 = true;

            bool b_all = true;
            if (b_t1 == false || b_t2 == false || b_t3 == false || b_t4 == false || b_t5 == false || b_t6 == false) b_all = false;

            产品测试数据TableAdapter.InsertQuery(global_values.产品id, tb_barcode.Text, "", t1, b_t1, t2, b_t3, t3, b_t4, t4, b_t4, t5, b_t5, t6, b_t6,b_all,
              DateTime.Now.ToString(), global_values.当前测试人, global_values.当前测试班组);

            if (b_all == true)
            { MessageBox.Show("产品合格!"); }
            else
            { MessageBox.Show("产品不合格!"); }

            MessageBox.Show("数据保存成功!");

        }

        private void 产品设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void 合格值范围ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_values_range fvr = new Form_values_range();
            fvr.ShowDialog();
        }

        private void 产品设置ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_product_settings fps = new Form_product_settings();
            fps.ShowDialog();
        }

        private void 测试数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_test_data ftd = new Form_test_data();
            ftd.ShowDialog();
        }

        private void 人员设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_worker_setting fws = new Form_worker_setting();
            fws.ShowDialog();
        }
    }
}
