using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form2 : Form
    {
        bool Clear;
        char variable;
        int Position;
        double Num;
        char Operator;
        double Answer;
        bool done;
        string Prev;
        string Sqrt;
        double Mem;
        public Form2()
        {
            InitializeComponent();

            Mem = 0;
            Sqrt = "";
            Operator = ' ';
            Position = 0;
            lblAnswer.Text = "0";
            Clear = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (Clear == true)
            {
                lblAnswer.Text = "";
                Clear = false;
                done = false;
            }

            if (Sqrt != "")
            { 
                lblDetails.Text = "";
                Answer = 0;
                Sqrt = "";
            }

            Button btn = (Button)sender;
            if (lblAnswer.Text != "0") { lblAnswer.Text += btn.Text; }
            else { lblAnswer.Text = btn.Text; }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "0";
            Clear = true;
            lblDetails.Text = "";
            Num = Position = 0;
            Operator = ' ';
        }

        private void btnClearCur_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "0";
            Clear = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Clear == false)
            {
                if (lblAnswer.Text.Length == 1)
                {
                    lblAnswer.Text = "0";
                    Clear = true;
                }
                else
                { lblAnswer.Text = lblAnswer.Text.Substring(0, lblAnswer.Text.Length - 1); }
            }
        }

        public void btnOperator_Click(object sender, EventArgs e)
        {
            Button sign = (Button)sender;
            Operator = sign.Text[0];
            Sqrt = "";
            if (done == false)
            {
                lblDetails.Text += " " + lblAnswer.Text + " " + Operator;
            }
            if (done == true)
            {
                lblDetails.Text = lblDetails.Text.Substring(0, lblDetails.Text.Length - 1) + Operator;
            }

            if (Position == 0)
            {
                Answer = Num = double.Parse(lblAnswer.Text);
                Clear = true;
                Position = 1;
                done = true;
            }
            else
            {
                if (done == false)
                {
                    Num = double.Parse(lblAnswer.Text);
                    lblAnswer.Text = Calculate();
                    done = true;
                }
            }

            variable = sign.Text[0];
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (lblAnswer.Text[0] != '-')
            {
                lblAnswer.Text = '-' + lblAnswer.Text;
            }
            else
            {
                lblAnswer.Text = lblAnswer.Text.Substring(1, lblAnswer.Text.Length - 1);
            }
        }

        public void btnEquals_Click(object sender, EventArgs e)
        {
            if (Position == 0)
            {
                Answer = double.Parse(lblAnswer.Text);
            }
            else
            {
                lblAnswer.Text = Calculate();
                lblDetails.Text = "";
                Position = 0;
            }
            done = false;
            Clear = true;


        }

        public string Calculate()
        {
            double curNum = double.Parse(lblAnswer.Text);

            if (variable == '+')
            { Answer += curNum; }
            if (variable == '-')
            { Answer -= curNum; }
            if (variable == '*')
            { Answer *= curNum; }
            if (variable == '/')
            { Answer /= curNum; }

            Clear = true;
            return Answer.ToString();
        }

        private void btnMemMinus_Click(object sender, EventArgs e)
        {
            MemOperation('-');
        }

        private void btnMemPlus_Click(object sender, EventArgs e)
        {
            MemOperation('+');
        }

        private void btnMemSave_Click(object sender, EventArgs e)
        {
            MemOperation('=');
        }

        private void btnMemClear_Click(object sender, EventArgs e)
        {
            MemOperation(' ');
        }

        private void btnMemRecall_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = Mem.ToString();
            Clear = true;
        }

        private void MemOperation(char Operator)
        {
            if (Operator == '+')
            { Mem += double.Parse(lblAnswer.Text); }

            if (Operator == '-')
            { Mem -= double.Parse(lblAnswer.Text); }

            if (Operator == '=')
            { Mem = double.Parse(lblAnswer.Text); }

            if (Operator == ' ')
            { Mem = 0; }

            Clear = true;


            if (Mem != 0)
            { lblMem.Text = "M"; }

            if (Mem == 0)
            { lblMem.Text = ""; }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            string KeyCode;

            if (e.KeyCode == Keys.Add)
            {
                btnPlus.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                btnMinus.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                btnMult.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)
            {
                btnDivd.PerformClick();
            }
            if (e.Modifiers == Keys.Shift)
            {
                if (e.KeyCode == Keys.Oemplus)
                {
                    btnPlus.PerformClick();
                }
                if (e.KeyCode == Keys.OemMinus)
                {
                    btnMinus.PerformClick();
                }
                if (e.KeyCode == Keys.D8)
                {
                    btnMult.PerformClick();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    btnMemSave.PerformClick();
                }
            }
            else
            {
                if (e.KeyCode == Keys.OemQuestion)
                {
                    btnDivd.PerformClick();
                }
                if (e.KeyCode == Keys.Oemplus)
                {
                    btnEquals.PerformClick();
                }
                if (e.KeyCode == Keys.Back)
                {
                    btnBack.PerformClick();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    btnEquals.PerformClick();
                }
                if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                {
                    if (Clear == true)
                    {
                        lblAnswer.Text = "";
                        Clear = false;
                    }
                    KeyCode = e.KeyCode.ToString();
                    if (lblAnswer.Text != "0") { lblAnswer.Text += KeyCode[1]; }
                    else { lblAnswer.Text = KeyCode[1].ToString(); }
                }
                if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
                {
                    if (Clear == true)
                    {
                        lblAnswer.Text = "";
                        Clear = false;
                    }
                    KeyCode = e.KeyCode.ToString();
                    if (lblAnswer.Text != "0") { lblAnswer.Text += KeyCode[6]; }
                    else { lblAnswer.Text = KeyCode[6].ToString(); }
                }
            }
        }

        public void btnSqrt_Click(object sender, EventArgs e)
        {
            if (done == false)
            {
                Prev = lblDetails.Text;
                Sqrt = "Sqrt(" + lblAnswer.Text + ")";
                done = true;
            }
            else
            {
                Sqrt = "Sqrt(" + Sqrt + ")";
            }
            lblDetails.Text = Prev + " " + Sqrt;

            Num = double.Parse(lblAnswer.Text);
            lblAnswer.Text = Math.Sqrt(Num).ToString();
            Position = 1;
            Clear = true;
        }



    }
}
