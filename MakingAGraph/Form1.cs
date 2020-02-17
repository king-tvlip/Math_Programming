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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GammaForm checkF = new GammaForm();
            Form3 form3 = new Form3();
            Form gForm = Form.ActiveForm;
            if((gForm.GetType() == checkF.GetType())||(gForm.GetType() == form3.GetType()))
            {
                gForm.Close();
            }
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form opForm = Form.ActiveForm;
            Form2 chForm = new Form2();
            Form3 form3 = new Form3();
            if ((opForm.GetType() == chForm.GetType())||(opForm.GetType() == form3.GetType()))
            {
                opForm.Close();
            }
            GammaForm gammaForm = new GammaForm(this);
            gammaForm.Show();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form activeForm = Form.ActiveForm;
            GammaForm gForm = new GammaForm();
            Form2 form2 = new Form2();
            if ((activeForm.GetType() == gForm.GetType())||(activeForm.GetType() == form2.GetType()))
            {
                activeForm.Close();
            }
            Form3 form3 = new Form3(this);
            form3.Show();
        }
    }
}
