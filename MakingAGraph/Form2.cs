using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakingAGraph
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            this.Load += Form2_Load;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.RowCount = Convert.ToInt32(textBox2.Text);
            tableLayoutPanel1.ColumnCount = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt32(textBox2.Text); j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Multiline = true;
                    tableLayoutPanel1.Controls.Add(textBox);
                    tableLayoutPanel1.Refresh();
                }
            }
            if(textBox2.Text != "")
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                button1.Visible = false;
                this.Refresh();
            }
        }
    }
}
