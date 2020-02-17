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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 f)
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.RowCount = Convert.ToInt32(textBox2.Text);
            tableLayoutPanel1.ColumnCount = Convert.ToInt32(textBox4.Text);
            for( int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
            {
                for( int j = 0; j < Convert.ToInt32(textBox4.Text); j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Multiline = true;
                    tableLayoutPanel1.Controls.Add(textBox);
                    tableLayoutPanel1.Refresh();
                }
            }
            if((textBox2.Text != "")&&(textBox4.Text != ""))
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                button1.Visible = false;
                this.Refresh();
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
