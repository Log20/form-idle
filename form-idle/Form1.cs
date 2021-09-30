using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_idle
{
    public partial class Form1 : Form
    {
        double num = 0, cnum, result;
        bool func, neg=false;
        string state;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(num);
            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void update()
        {
            num = Convert.ToDouble(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
        ///////////////////////////////////////////////////////////number
        #region
        private void bnum1_Click(object sender, EventArgs e)//1
        {
            textBox1.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) * 10) + 1);
            update();
        }

        private void bnum2_Click(object sender, EventArgs e)//2
        {
            textBox1.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) * 10) + 2);
            update();
        }

        private void bnum3_Click(object sender, EventArgs e)//3
        {
            textBox1.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) * 10) + 3);
            update();
        }

        private void bnum4_Click(object sender, EventArgs e)//4
        {
            textBox1.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) * 10) + 4);
            update();
        }

        private void bnum5_Click(object sender, EventArgs e)//5
        {
            textBox1.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) * 10) + 5);
            update();
        }

        private void bnum6_Click(object sender, EventArgs e)//6
        {
            textBox1.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) * 10) + 6);
            update();
        }

        private void bnum7_Click(object sender, EventArgs e)//7
        {
            textBox1.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) * 10) + 7);
            update();
        }

        private void bnum8_Click(object sender, EventArgs e)//8
        {
            textBox1.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) * 10) + 8);
            update();
        }

        private void bnum9_Click(object sender, EventArgs e)//9
        {
            textBox1.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) * 10) + 9);
            update();
        }

        private void bnum0_Click(object sender, EventArgs e)//0
        {
            textBox1.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) * 10) + 0);
            update();
        }
        #endregion
        ///////////////////////////////////////////////////////////calculate
        #region
        private void bplus_Click(object sender, EventArgs e)//+
        {
            if (state == null)
            {
                update();
                state = "+";
                cnum = num;
                num = 0;
                label1.Text = Convert.ToString(cnum) + " +";
                textBox1.Text = "0";
            }
            else if (state != "+")
            {
                state = "+";
                label1.Text = Convert.ToString(cnum) + " +";
            }
            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void bminus_Click(object sender, EventArgs e)//-
        {
            if (state == null)
            {
                update();
                state = "-";
                cnum = num;
                num = 0;
                label1.Text = Convert.ToString(cnum) + " -";
                textBox1.Text = "0";
            }
            else if (state != "-")
            {
                state = "-";
                label1.Text = Convert.ToString(cnum) + " -";
            }
            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void btime_Click(object sender, EventArgs e)//*
        {
            if (state == null)
            {
                update();
                state = "*";
                cnum = num;
                num = 0;
                label1.Text = Convert.ToString(cnum) + " X";
                textBox1.Text = "0";
            }
            else if (state != "*")
            {
                state = "*";
                label1.Text = Convert.ToString(cnum) + " X";
            }
            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void bdiv_Click(object sender, EventArgs e)//÷
        {
            if (state == null)
            {
                update();
                state = "/";
                cnum = num;
                num = 0;
                label1.Text = Convert.ToString(cnum) + " ÷";
                textBox1.Text = "0";
            }
            else if (state != "/")
            {
                state = "/";
                label1.Text = Convert.ToString(cnum) + " ÷";
            }
            textBox1.Focus();
            textBox1.SelectAll();
        }
        #endregion
        ///////////////////////////////////////////////////////////control
        #region
        private void bc_Click(object sender, EventArgs e)
        {
            cnum = 0;
            num = 0;
            state = null;
            label1.Text = null;
            textBox1.Text = Convert.ToString(num);

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    bplus_Click(null, null);
                    break;
                case Keys.Subtract:
                    bminus_Click(null, null);
                    break;
                case Keys.Multiply:
                    btime_Click(null, null);
                    break;
                case Keys.Divide:
                    bdiv_Click(null, null);
                    break;
                case Keys.Return:
                    bsame_Click(null, null);
                    break;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Divide)
            {
                textBox1.Text = "0";
                textBox1.SelectAll();
            }
        }

        private void bback_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 1)
            {
                num = 0;
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            update();
        }
        #endregion
        ///////////////////////////////////////////////////////////utility
        #region
        private void bxx_Click(object sender, EventArgs e)
        {
            if (func == false) textBox1.Text = Math.Pow(Convert.ToDouble(textBox1.Text), 2).ToString();
            else textBox1.Text = Math.Pow(Convert.ToDouble(textBox1.Text), 3).ToString();
            update();
        }

        private void bxn_Click(object sender, EventArgs e)
        {
            if (func == false)
            {
                if (state == null)
                {
                    update();
                    state = "^";
                    cnum = num;
                    num = 0;
                    label1.Text = Convert.ToString(cnum) + " ^";
                    textBox1.Text = "0";
                }
                else if (state != "^")
                {
                    state = "^";
                    label1.Text = Convert.ToString(cnum) + " ^";
                }
                textBox1.Focus();
                textBox1.SelectAll();
            }
            else
            {
                if (state == null)
                {
                    update();
                    state = "√";
                    cnum = num;
                    num = 0;
                    label1.Text = Convert.ToString(cnum) + " √";
                    textBox1.Text = "0";
                }
                else if (state != "√")
                {
                    state = "√";
                    label1.Text = Convert.ToString(cnum) + " √";
                }
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }

        private void bsin_Click(object sender, EventArgs e)
        {
            if (func == false) textBox1.Text = Math.Sin(Convert.ToDouble(textBox1.Text) * Math.PI / 180).ToString();
            ///else 
        }

        private void bcos_Click(object sender, EventArgs e)
        {

        }

        private void btan_Click(object sender, EventArgs e)
        {

        }

        private void bdx_Click(object sender, EventArgs e)
        {

        }

        private void b10n_Click(object sender, EventArgs e)
        {

        }

        private void blog_Click(object sender, EventArgs e)
        {

        }

        private void bexp_Click(object sender, EventArgs e)
        {

        }

        private void bmod_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void bup_Click(object sender, EventArgs e)
        {
            if (func == false)
            {
                func = true;
                bup.BackColor = SystemColors.ButtonShadow;
                bxx.Text = "x³";
                bxn.Text = "n√x";
                bsin.Text = "sin⁻¹";
                bcos.Text = "cos⁻¹";
                btan.Text = "tan⁻¹";
                bdx.Text = "1/x";
                b10n.Text = "eⁿ";
                blog.Text = "ln";
                bexp.Text = "dms";
                bmod.Text = "deg";
            }
            else
            {
                func = false;
                bup.BackColor = SystemColors.ButtonFace;
                bxx.Text = "x²";
                bxn.Text = "xⁿ";
                bsin.Text = "sin";
                bcos.Text = "cos";
                btan.Text = "tan";
                bdx.Text = "√";
                b10n.Text = "10ⁿ";
                blog.Text = "log";
                bexp.Text = "Exp";
                bmod.Text = "Mod";
            }
            update();
        }

        private void bus_Click(object sender, EventArgs e)
        {
            if (neg == false)
            {
                textBox1.Text = "-" + textBox1.Text;
                neg = true;
            }
            else
            {
                textBox1.Text.Replace("-", string.Empty);
                neg = false;
            }
        }

        private void bce_Click(object sender, EventArgs e)
        {
            num = 0;
            textBox1.Text = Convert.ToString(num);
        }

        private void bsame_Click(object sender, EventArgs e)//=
        {
            update();
            switch (state)
            {
                case "+":
                    result = cnum + num; //add
                    break;
                case "-":
                    result = cnum - num; //minus
                    break;
                case "*":
                    result = cnum * num; //multiply
                    break;
                case "/":
                    result = cnum / num; //divide
                    break;
                case "^":
                    result = Math.Pow(cnum, num);//power
                    break;
                case "√":
                    result = Math.Pow(cnum, (1 / num));//root
                    break;
            }
            if (state != null)
            {
                historyBox.Items.Add(cnum.ToString() + state + num.ToString() + "=" + result.ToString());
            }
            state = null;
            cnum = 0;
            num = result;
            textBox1.Text = Convert.ToString(num);
            label1.Text = null;
            textBox1.SelectAll();
            textBox1.Focus();
        }
    }
}
