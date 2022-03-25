using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppForm3
{
    public partial class Form1 : Form
    {
        int count;
        float num1, ans;
        public Form1()
        {
            InitializeComponent();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            txtResult.Text = txtResult.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 0;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(txtResult.Text);
                    txtResult.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(txtResult.Text);
                    txtResult.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txtResult.Text);
                    txtResult.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(txtResult.Text);
                    txtResult.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtResult.Clear();
            count = 0;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResult.Text);
            txtResult.Clear();
            txtResult.Focus();
            count = 3;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResult.Text);
            txtResult.Clear();
            txtResult.Focus();
            count = 4;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                num1 = float.Parse(txtResult.Text);
                txtResult.Clear();
                txtResult.Focus();
                count = 1;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResult.Text);
            txtResult.Clear();
            txtResult.Focus();
            count = 2;
        }
    }
}
