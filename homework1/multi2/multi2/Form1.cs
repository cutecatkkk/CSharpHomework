using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)//判断输入是否合法，应该检测输入的是否数字或者不允许输入数字以外的字符比较合适。
            {
                MessageBox.Show("请输入数字");//当输入不合法时，弹出信息窗提示不合法
                return;
            }
            try
            {
                double x = double.Parse(textBox1.Text);//获取文本框1中的内容
                double y = double.Parse(textBox2.Text);//同理
                textBox3.Text = (x * y).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
