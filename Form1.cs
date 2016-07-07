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
    public partial class Form1 : Form
    {
        int T { get; set; }
        int B { get; set; }
        Button[] BtnList { get; set; }
        Button ActiveBtn { get; set; }
        Dictionary<RadioButton, TextBox> TxtList { get; set; }
        RadioButton Fixed { get; set; }
        string Result { get; set; }
        int CrtIndx { get; set; }

        public Form1()
        {
            InitializeComponent();
            T = 0;
            B = 0;
            BtnList = new Button[4] { btnPlus, btnMinus, btnMult, btnDivd };
            TxtList = new Dictionary<RadioButton, TextBox>();
            TxtList.Add(optNum, txtNum2);
            TxtList.Add(optRes, txtResult);
            Fixed = pnlTxt.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            foreach (Button btn in BtnList)
            {
                btn.ForeColor = Color.Black;
                btn.BackColor = Control.DefaultBackColor;
            }
            TxtList[Fixed].Enabled = false;
            txtNum1.Text = "Write Number 1 here";
            txtNum2.Text = "Write Number 2 here";
            txtNum1.Tag = "true";
            txtNum2.Tag = "true";
        }

        private void txtMouseClick(object sender, MouseEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            txt.TextAlign = HorizontalAlignment.Right;
            if ((string)txt.Tag == "true")
            { txt.Text = ""; }
            txt.Tag = "false";

            if (txt.Name == txtNum1.Name)
            {
                T = 1;
            }
            else
            {
                T = 2;
            }

            txtResult.Text = "0";
            CrtIndx = txt.SelectionStart;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            lblRes.Text = "";
            txtResult.Text = "Result";
            lblDet.Text = "";
            lblWarning.Text = "";
            T = 0;
            B = 0;
        }

        public void OperationButnClickd(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Text)
            {
                case "+":
                    B = 1;
                    break;
                case "-":
                    B = 2;
                    break;
                case "*":
                    B = 3;
                    break;
                case "/":
                    B = 4;
                    break;
            }

            ChangeBtnColor();
            PerformOperation();
        }

        public void PerformOperation()
        {
            double Num1 = 0;
            double Num2 = 0;
            double Res = 0;
            int Ok;

            Ok = (double.TryParse(txtNum1.Text, out Num1) ? 1 : 0) *
                 (double.TryParse(txtNum2.Text, out Num2) ? 1 : 0) *
                 (double.TryParse(txtResult.Text, out Res) ? 1 : 0);

            if (Ok == 1)
            {
                lblRes.Text = "Result is";
                if (Fixed == optRes)
                {
                    switch (B)
                    {
                        case 1:
                            txtResult.Text = Convert.ToString(Num1 + Num2);
                            break;
                        case 2:
                            txtResult.Text = Convert.ToString(Num1 - Num2);
                            break;
                        case 3:
                            txtResult.Text = Convert.ToString(Num1 * Num2);
                            break;
                        case 4:
                            txtResult.Text = Convert.ToString(Num1 / Num2);
                            break;
                    }

                }
                else
                {
                        switch (B)
                        {
                            case 1:
                                txtNum2.Text = Convert.ToString(Res - Num1);
                                break;
                            case 2:
                                txtNum2.Text = Convert.ToString(Num1 - Res);
                                break;
                            case 3:
                                txtNum2.Text = Convert.ToString(Res / Num1);
                                break;
                            case 4:
                                txtNum2.Text = Convert.ToString(Num1 / Res);
                                break;
                        }
                    

                }

                if (B != 0)
                { lblDet.Text = "(" + Num1 + BtnList[B - 1].Text + Num2 + ")"; }
            }
        }

        public void ChangeBtnColor()
        {
            for (int i = 0; i < 4; i++)
            {

                if (B == i + 1)
                {
                    BtnList[i].BackColor = Color.Black;
                    BtnList[i].ForeColor = Color.White;
                }
                else
                {
                    BtnList[i].BackColor = Control.DefaultBackColor;
                    BtnList[i].ForeColor = Color.Black;
                }
            }
        }

        public void Clear()
        {
            txtNum1.TextAlign = HorizontalAlignment.Center;
            txtNum2.TextAlign = HorizontalAlignment.Center;
            txtNum1.Text = "-";
            txtNum2.Text = "-";
            txtNum1.Tag = "true";
            txtNum2.Tag = "true";
        }
        private void TxtChngd(object text, EventArgs e)
        {
            TextBox txt = (TextBox)text;

            if (txt != txtResult)
            {
                if (txt.Text.Length == 10)
                {
                    lblWarning.Text = "Maximum Length Reached";
                }

                if (txt.Text.Length == 11)
                {
                    txt.Text = txt.Text.Substring(0, 10);
                    txt.SelectionStart = CrtIndx;
                    CrtIndx -= 1;
                }
            }

            PerformOperation();
        }

        private void KyDwn(object text, KeyEventArgs e)
        {
            TextBox txt = (TextBox)text;

            if (e.KeyValue <= 111 && e.KeyValue >= 106 && e.KeyValue != 110)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                switch (e.KeyValue)
                {
                    case 106:
                        btnMult.PerformClick();
                        btnMult.Focus();
                        break;
                    case 107:
                        btnPlus.PerformClick();
                        btnPlus.Focus();
                        break;
                    case 109:
                        btnMinus.PerformClick();
                        btnMinus.Focus();
                        break;
                    case 111:
                        btnDivd.PerformClick();
                        btnDivd.Focus();
                        break;
                }
            }

            else if (e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyValue >= 48 && e.KeyValue <= 57)
            {
                CrtIndx += 1;
            }

            else if (e.KeyValue == 8)
            {
                CrtIndx -= 1;
            }

            else if (e.KeyValue >= 37 && e.KeyValue <= 40)
            {
                switch (e.KeyValue)
                {
                    case 37:
                    case 38:
                        if (CrtIndx > 0)
                        {
                            CrtIndx -= 1;
                        }
                        else
                        {
                            lblWarning.Text = "No numbers before Caret";
                        }
                        break;
                    case 39:
                    case 40:
                        if (CrtIndx < txt.Text.Length)
                        {
                            CrtIndx += 1;
                        }
                        else
                        {
                            lblWarning.Text = "No numbers after Caret";
                        }
                        break;
                }
            }

            else
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                txtResult.Text = "Please input numbers";
                txtResult.Focus();
            }
        }

        public void Insert(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            TextBox txt;

            if (T == 0)
            {
                lblWarning.Text = "Please select a box";
            }
            else
            {
                if (T == 1)
                {
                    txt = txtNum1;
                }
                else
                {
                    txt = txtNum2;
                }

                txt.Text = txt.Text.Insert(CrtIndx, btn.Text);
                CrtIndx += 1;
                Focus(txt);
            }
        }

        public void BackSpace(object sender, EventArgs e)
        {
            TextBox txt;

            if (CrtIndx > 0)
            {
                if (T == 0)
                {
                    lblWarning.Text = "Please select a box";
                }
                else
                {
                    if (T == 1)
                    {
                        txt = txtNum1;
                    }
                    else
                    {
                        txt = txtNum2;
                    }

                    txt.Text = txt.Text.Substring(0, CrtIndx - 1) + txt.Text.Substring(CrtIndx, txt.Text.Length - CrtIndx);
                    CrtIndx -= 1;
                    Focus(txt);
                }
            }
            else
            {
                txtResult.Text = "No numbers before Caret";
            }
        }

        public void Focus(TextBox txt)
        {
            txt.Focus();
            txt.SelectionStart = CrtIndx;
            txt.SelectionLength = 0;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            foreach (TextBox txt in TxtList.Values)
            {
                txt.Enabled = true;
            }

            Fixed = pnlTxt.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            TxtList[Fixed].Enabled = false;
        }



    }
}
