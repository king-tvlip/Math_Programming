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
    public partial class GammaForm : Form
    {
        public GammaForm()
        {
            InitializeComponent();
        }

        public GammaForm(Form1 f)
        {
            InitializeComponent();
            this.Load += GammaForm_Load;
        }

        public static void GammaForm_Load(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();
            textBox1.Location = new Point(52, 53);
            textBox1.Text = "Введите колиличество вершин:";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
            {
                TextBox textBox = new TextBox();
                textBox.Multiline = true;
                tableLayoutPanel1.Controls.Add(textBox);
                tableLayoutPanel1.Refresh();
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
