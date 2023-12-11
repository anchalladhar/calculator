using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace SC
{
    public partial class frmScientificCalculator : Form
    {
        int sign = 0;
        double num1;
        double num2;
        int add = 0;
        int sub = 0;
        int mul = 0;
        int div = 0;
        int modBit = 0;
        Boolean fl = false;
        String s, x;
 
        public frmScientificCalculator()
        {
            InitializeComponent();
        }
 
        private void btn1_Click(object sender, EventArgs e)
        {
            if (sign == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(1);
            }
            else if (sign == 1)
            {
                txtInput.Text = Convert.ToString(1);
                sign = 0;
            }
            fl = true;
        }
 
        private void btn2_Click(object sender, EventArgs e)
        {
            if (sign == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(2);
            }
            else if (sign == 1)
            {
                txtInput.Text = Convert.ToString(2);
                sign = 0;
            }
           fl=true;
        }
 
        private void btn3_Click(object sender, EventArgs e)
        {
            if (sign == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(3);
            }
            else if (sign == 1)
            {
                txtInput.Text = Convert.ToString(3);
                sign = 0;
            }
           fl=true;
        }
 
        private void btn4_Click(object sender, EventArgs e)
        {
            if (sign == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(4);
            }
            else if (sign == 1)
            {
                txtInput.Text = Convert.ToString(4);
                sign = 0;
            }
           fl=true;
        }
 
        private void btn5_Click(object sender, EventArgs e)
        {
            if (sign == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(5);
            }
            else if (sign == 1)
            {
                txtInput.Text = Convert.ToString(5);
                sign = 0;
            }
           fl=true;
        }
 
        private void btn6_Click(object sender, EventArgs e)
        {
            if (sign == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(6);
            }
            else if (sign == 1)
            {
                txtInput.Text = Convert.ToString(6);
                sign = 0;
            }
           fl=true;
        }
 
        private void btn7_Click(object sender, EventArgs e)
        {
            if (sign == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(7);
            }
            else if (sign == 1)
            {
                txtInput.Text = Convert.ToString(7);
                sign = 0;
            }
           fl=true;
        }
 
        private void btn8_Click(object sender, EventArgs e)
        {
            if (sign == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(8);
            }
            else if (sign == 1)
            {
                txtInput.Text = Convert.ToString(8);
                sign = 0;
            }
           fl=true;
        }
 
        private void btnnine_Click(object sender, EventArgs e)
        {
            if (sign == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(9);
            }
            else if (sign == 1)
            {
                txtInput.Text = Convert.ToString(9);
                sign = 0;
            }
           fl=true;
        }
 
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (sign == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(0);
            }
            else if (sign == 1)
            {
                txtInput.Text = Convert.ToString(0);
                sign = 0;
            }
           fl=true;
        }
        private void reset_SignBits()
        {
        add = 0;
        sub = 0;
        mul = 0;
        div = 0;
        modBit = 0;
        fl = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                add = 1;
                sign = 1;
            }
        }
 
       
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                num2 = Convert.ToDouble(txtInput.Text);
                calculate();
                reset_SignBits();
                sub = 1;
                sign = 1;
            }
        }
 
        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                mul = 1;
                sign = 1;
            }
        }
 
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                div = 1;
                sign = 1;
            }
        }
 
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
            }
            sign = 1;
        }
 
        private void btnDot_Click(object sender, EventArgs e)
        {
            int i = 0;
            char chr = '\0';
            int decimal_Indicator = 0;
            int l = txtInput.Text.Length-1;
            if (sign != 1)
            {
                for (i = 0; i <= l; i++)
                {
                    chr = txtInput.Text[i];
                    if (chr == '.')
                    {
                        decimal_Indicator = 1;
                    }
                }
 
                if (decimal_Indicator != 1)
                {
                    txtInput.Text = txtInput.Text + Convert.ToString(".");
                }
            }
        }
 
        private void btnsqrt_Click(object sender, EventArgs e)
        {
            double s,l;
            l = Convert.ToDouble(txtInput.Text);
            s = Math.Sqrt(l);
            txtInput.Text = Convert.ToString(s);
        }
 
        private void btn1divx_Click(object sender, EventArgs e)
        {
            txtInput.Text = (1 / Convert.ToDouble(txtInput.Text)).ToString();
        }
 
        private void btnxfoctorial_Click(object sender, EventArgs e)
        {
            try
            {
                long fact = 1;
                for (int i = 1; i <= Convert.ToInt32(txtInput.Text); i++)
                {
                    fact = fact * i;
                }
                txtInput.Text = Convert.ToString(fact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Log(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnLog10_Click(object sender, EventArgs e)
        {
              try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Log10(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
 }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnex_Click(object sender, EventArgs e)
        {
              try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Exp(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void Form6_Load(object sender, EventArgs e)
        {
    
        }
 
        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Sin(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnCos_Click(object sender, EventArgs e)
        {
              try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Cos(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnTan_Click(object sender, EventArgs e)
        {
              try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Tan(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnRound_Click(object sender, EventArgs e)
        {
              try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Round(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnFloor_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Floor(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnTruncate_Click(object sender, EventArgs e)
        {
            try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Truncate(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnCeil_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Ceiling(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnInvSin_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Asin(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnSinh_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Sinh(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnCosh_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Cosh(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void button24_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Tanh(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnInvCos_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Acos(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnInvTan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
            double l;
            l = Math.Atan(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
 }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void calculate()
        {
            if (txtInput.Text != ".")
            {
                num2 = Convert.ToDouble(txtInput.Text);
                if (fl == false)
                {
                    num1 = num2;
                }
                else if (add == 1)
                {
                    num1 = num1 + num2;
                }
                else if (sub == 1)
                {
                    num1 = num1 - num2;
                }
                else if (mul == 1)
                {
                    num1 = num1 * num2;
                }
                else if (div == 1)
                {
                    num1 = num1 / num2;
                }
                else if (modBit == 1)
                {
 
                    num2 = Convert.ToInt32(txtInput.Text);
                    num1 = Convert.ToInt32(num1 % num2);
                }
               
                else
                {
                    num1 = num2;
                }
                txtInput.Text = Convert.ToString(num1);
 
            }
          }
 
        private void btnmod_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                modBit = 1;
                sign = 1;
            }
        }
 
        private void btnPI_Click(object sender, EventArgs e)
        {
            txtInput.Text = Math.PI.ToString();
            sign = 1;
        }
 
        private void btnCLR_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            sign = 0;
            num1 = 0;
            num2 = 0;
            reset_SignBits();
        }
 
        private void btnbackspace_Click(object sender, EventArgs e)
        {
            s = txtInput.Text;
            int l = s.Length;
            for (int i = 0; i < l - 1; i++)
            {
                x += s[i];
            }
            txtInput.Text = x;
            x = "";
        }
       
    }
}