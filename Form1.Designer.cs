namespace Test1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblDet = new System.Windows.Forms.Label();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivd = new System.Windows.Forms.Button();
            this.pnlOperators = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.optRes = new System.Windows.Forms.RadioButton();
            this.optNum = new System.Windows.Forms.RadioButton();
            this.pnlTxt = new System.Windows.Forms.Panel();
            this.pnlOperators.SuspendLayout();
            this.pnlTxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(23, 7);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(104, 20);
            this.txtNum1.TabIndex = 4;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum1.TextChanged += new System.EventHandler(this.TxtChngd);
            this.txtNum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KyDwn);
            this.txtNum1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtMouseClick);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(23, 50);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(104, 20);
            this.txtNum2.TabIndex = 5;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum2.TextChanged += new System.EventHandler(this.TxtChngd);
            this.txtNum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KyDwn);
            this.txtNum2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtMouseClick);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnClear.Location = new System.Drawing.Point(208, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(42, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(32, 139);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(31, 23);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Insert);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(80, 139);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(31, 23);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Insert);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(128, 139);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(31, 23);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Insert);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(128, 168);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(31, 23);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Insert);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(80, 168);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(31, 23);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Insert);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(32, 168);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(31, 23);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Insert);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(32, 227);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(79, 23);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Insert);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(128, 197);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(31, 23);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Insert);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(80, 197);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(31, 23);
            this.btn8.TabIndex = 16;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Insert);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(32, 197);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(31, 23);
            this.btn7.TabIndex = 17;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Insert);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(29, 97);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 18;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(135, 9);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 19;
            // 
            // lblDet
            // 
            this.lblDet.AutoSize = true;
            this.lblDet.ForeColor = System.Drawing.Color.Gray;
            this.lblDet.Location = new System.Drawing.Point(135, 56);
            this.lblDet.Name = "lblDet";
            this.lblDet.Size = new System.Drawing.Size(0, 13);
            this.lblDet.TabIndex = 20;
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(128, 226);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(31, 23);
            this.btnDot.TabIndex = 21;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.Insert);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Location = new System.Drawing.Point(165, 139);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BackSpace);
            // 
            // btnMult
            // 
            this.btnMult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnMult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMult.Location = new System.Drawing.Point(1, 31);
            this.btnMult.Margin = new System.Windows.Forms.Padding(0);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(45, 30);
            this.btnMult.TabIndex = 1;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.OperationButnClickd);
            // 
            // btnPlus
            // 
            this.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlus.Location = new System.Drawing.Point(1, 1);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(45, 30);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.OperationButnClickd);
            // 
            // btnMinus
            // 
            this.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinus.Location = new System.Drawing.Point(1, 61);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(45, 30);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.OperationButnClickd);
            // 
            // btnDivd
            // 
            this.btnDivd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDivd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDivd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnDivd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDivd.Location = new System.Drawing.Point(1, 91);
            this.btnDivd.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivd.Name = "btnDivd";
            this.btnDivd.Size = new System.Drawing.Size(45, 30);
            this.btnDivd.TabIndex = 2;
            this.btnDivd.Text = "/";
            this.btnDivd.UseVisualStyleBackColor = true;
            this.btnDivd.Click += new System.EventHandler(this.OperationButnClickd);
            // 
            // pnlOperators
            // 
            this.pnlOperators.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOperators.Controls.Add(this.btnDivd);
            this.pnlOperators.Controls.Add(this.btnMinus);
            this.pnlOperators.Controls.Add(this.btnPlus);
            this.pnlOperators.Controls.Add(this.btnMult);
            this.pnlOperators.Location = new System.Drawing.Point(208, 131);
            this.pnlOperators.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOperators.Name = "pnlOperators";
            this.pnlOperators.Size = new System.Drawing.Size(47, 122);
            this.pnlOperators.TabIndex = 23;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(155, 27);
            this.txtResult.MaxLength = 5;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 24;
            this.txtResult.TextChanged += new System.EventHandler(this.TxtChngd);
            this.txtResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KyDwn);
            // 
            // optRes
            // 
            this.optRes.AutoSize = true;
            this.optRes.Checked = true;
            this.optRes.Location = new System.Drawing.Point(138, 30);
            this.optRes.Name = "optRes";
            this.optRes.Size = new System.Drawing.Size(14, 13);
            this.optRes.TabIndex = 26;
            this.optRes.TabStop = true;
            this.optRes.UseVisualStyleBackColor = true;
            this.optRes.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // optNum
            // 
            this.optNum.AutoSize = true;
            this.optNum.Location = new System.Drawing.Point(3, 53);
            this.optNum.Name = "optNum";
            this.optNum.Size = new System.Drawing.Size(14, 13);
            this.optNum.TabIndex = 27;
            this.optNum.TabStop = true;
            this.optNum.UseVisualStyleBackColor = true;
            this.optNum.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // pnlTxt
            // 
            this.pnlTxt.Controls.Add(this.optNum);
            this.pnlTxt.Controls.Add(this.optRes);
            this.pnlTxt.Controls.Add(this.txtResult);
            this.pnlTxt.Controls.Add(this.lblDet);
            this.pnlTxt.Controls.Add(this.lblRes);
            this.pnlTxt.Controls.Add(this.txtNum2);
            this.pnlTxt.Controls.Add(this.txtNum1);
            this.pnlTxt.Location = new System.Drawing.Point(0, 6);
            this.pnlTxt.Name = "pnlTxt";
            this.pnlTxt.Size = new System.Drawing.Size(277, 84);
            this.pnlTxt.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pnlTxt);
            this.Controls.Add(this.pnlOperators);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.pnlOperators.ResumeLayout(false);
            this.pnlTxt.ResumeLayout(false);
            this.pnlTxt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblDet;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDivd;
        private System.Windows.Forms.Panel pnlOperators;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton optRes;
        private System.Windows.Forms.RadioButton optNum;
        private System.Windows.Forms.Panel pnlTxt;

    }
}

