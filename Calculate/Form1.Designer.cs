﻿namespace Calculate
{
    partial class fCalc
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsin = new System.Windows.Forms.Button();
            this.bCos = new System.Windows.Forms.Button();
            this.bTg = new System.Windows.Forms.Button();
            this.bSqrt = new System.Windows.Forms.Button();
            this.bX_in2 = new System.Windows.Forms.Button();
            this.bNum1 = new System.Windows.Forms.Button();
            this.bNum4 = new System.Windows.Forms.Button();
            this.bNum2 = new System.Windows.Forms.Button();
            this.bNum3 = new System.Windows.Forms.Button();
            this.bNum5 = new System.Windows.Forms.Button();
            this.bNum6 = new System.Windows.Forms.Button();
            this.bNum8 = new System.Windows.Forms.Button();
            this.bNum7 = new System.Windows.Forms.Button();
            this.bNum9 = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bNum0 = new System.Windows.Forms.Button();
            this.bPoint = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bRavno = new System.Windows.Forms.Button();
            this.bUmn = new System.Windows.Forms.Button();
            this.bDelenie = new System.Windows.Forms.Button();
            this.tb_Calc = new System.Windows.Forms.TextBox();
            this.Anim = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bsin
            // 
            this.bsin.BackColor = System.Drawing.Color.Yellow;
            this.bsin.Location = new System.Drawing.Point(242, 93);
            this.bsin.Name = "bsin";
            this.bsin.Size = new System.Drawing.Size(40, 37);
            this.bsin.TabIndex = 0;
            this.bsin.Text = "sin(x)";
            this.bsin.UseVisualStyleBackColor = false;
            this.bsin.Click += new System.EventHandler(this.bsin_Click);
            // 
            // bCos
            // 
            this.bCos.BackColor = System.Drawing.Color.Yellow;
            this.bCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCos.Location = new System.Drawing.Point(288, 95);
            this.bCos.Name = "bCos";
            this.bCos.Size = new System.Drawing.Size(40, 37);
            this.bCos.TabIndex = 1;
            this.bCos.Text = "cos(x)";
            this.bCos.UseVisualStyleBackColor = false;
            this.bCos.Click += new System.EventHandler(this.bCos_Click);
            // 
            // bTg
            // 
            this.bTg.BackColor = System.Drawing.Color.Yellow;
            this.bTg.Location = new System.Drawing.Point(242, 179);
            this.bTg.Name = "bTg";
            this.bTg.Size = new System.Drawing.Size(40, 37);
            this.bTg.TabIndex = 2;
            this.bTg.Text = "tg(x)";
            this.bTg.UseVisualStyleBackColor = false;
            this.bTg.Click += new System.EventHandler(this.bTg_Click);
            // 
            // bSqrt
            // 
            this.bSqrt.BackColor = System.Drawing.Color.Yellow;
            this.bSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSqrt.Location = new System.Drawing.Point(288, 138);
            this.bSqrt.Name = "bSqrt";
            this.bSqrt.Size = new System.Drawing.Size(40, 37);
            this.bSqrt.TabIndex = 8;
            this.bSqrt.Text = "sqrt(x)";
            this.bSqrt.UseVisualStyleBackColor = false;
            this.bSqrt.Click += new System.EventHandler(this.bSqrt_Click);
            // 
            // bX_in2
            // 
            this.bX_in2.BackColor = System.Drawing.Color.Yellow;
            this.bX_in2.Location = new System.Drawing.Point(242, 137);
            this.bX_in2.Name = "bX_in2";
            this.bX_in2.Size = new System.Drawing.Size(40, 37);
            this.bX_in2.TabIndex = 9;
            this.bX_in2.Text = "x^2";
            this.bX_in2.UseVisualStyleBackColor = false;
            this.bX_in2.Click += new System.EventHandler(this.bX_in2_Click);
            // 
            // bNum1
            // 
            this.bNum1.BackColor = System.Drawing.Color.Yellow;
            this.bNum1.Location = new System.Drawing.Point(12, 94);
            this.bNum1.Name = "bNum1";
            this.bNum1.Size = new System.Drawing.Size(40, 37);
            this.bNum1.TabIndex = 12;
            this.bNum1.Text = "1";
            this.bNum1.UseVisualStyleBackColor = false;
            this.bNum1.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum4
            // 
            this.bNum4.BackColor = System.Drawing.Color.Yellow;
            this.bNum4.Location = new System.Drawing.Point(12, 137);
            this.bNum4.Name = "bNum4";
            this.bNum4.Size = new System.Drawing.Size(40, 37);
            this.bNum4.TabIndex = 13;
            this.bNum4.Text = "4";
            this.bNum4.UseVisualStyleBackColor = false;
            this.bNum4.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum2
            // 
            this.bNum2.BackColor = System.Drawing.Color.Yellow;
            this.bNum2.Location = new System.Drawing.Point(58, 94);
            this.bNum2.Name = "bNum2";
            this.bNum2.Size = new System.Drawing.Size(40, 37);
            this.bNum2.TabIndex = 14;
            this.bNum2.Text = "2";
            this.bNum2.UseVisualStyleBackColor = false;
            this.bNum2.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum3
            // 
            this.bNum3.BackColor = System.Drawing.Color.Yellow;
            this.bNum3.Location = new System.Drawing.Point(104, 94);
            this.bNum3.Name = "bNum3";
            this.bNum3.Size = new System.Drawing.Size(40, 37);
            this.bNum3.TabIndex = 15;
            this.bNum3.Text = "3";
            this.bNum3.UseVisualStyleBackColor = false;
            this.bNum3.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum5
            // 
            this.bNum5.BackColor = System.Drawing.Color.Yellow;
            this.bNum5.Location = new System.Drawing.Point(58, 137);
            this.bNum5.Name = "bNum5";
            this.bNum5.Size = new System.Drawing.Size(40, 37);
            this.bNum5.TabIndex = 16;
            this.bNum5.Text = "5";
            this.bNum5.UseVisualStyleBackColor = false;
            this.bNum5.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum6
            // 
            this.bNum6.BackColor = System.Drawing.Color.Yellow;
            this.bNum6.Location = new System.Drawing.Point(104, 137);
            this.bNum6.Name = "bNum6";
            this.bNum6.Size = new System.Drawing.Size(40, 37);
            this.bNum6.TabIndex = 17;
            this.bNum6.Text = "6";
            this.bNum6.UseVisualStyleBackColor = false;
            this.bNum6.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum8
            // 
            this.bNum8.BackColor = System.Drawing.Color.Yellow;
            this.bNum8.Location = new System.Drawing.Point(60, 180);
            this.bNum8.Name = "bNum8";
            this.bNum8.Size = new System.Drawing.Size(40, 37);
            this.bNum8.TabIndex = 18;
            this.bNum8.Text = "8";
            this.bNum8.UseVisualStyleBackColor = false;
            this.bNum8.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum7
            // 
            this.bNum7.BackColor = System.Drawing.Color.Yellow;
            this.bNum7.Location = new System.Drawing.Point(14, 180);
            this.bNum7.Name = "bNum7";
            this.bNum7.Size = new System.Drawing.Size(40, 37);
            this.bNum7.TabIndex = 19;
            this.bNum7.Text = "7";
            this.bNum7.UseVisualStyleBackColor = false;
            this.bNum7.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum9
            // 
            this.bNum9.BackColor = System.Drawing.Color.Yellow;
            this.bNum9.Location = new System.Drawing.Point(104, 180);
            this.bNum9.Name = "bNum9";
            this.bNum9.Size = new System.Drawing.Size(40, 37);
            this.bNum9.TabIndex = 20;
            this.bNum9.Text = "9";
            this.bNum9.UseVisualStyleBackColor = false;
            this.bNum9.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.Yellow;
            this.bClear.Location = new System.Drawing.Point(14, 223);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(40, 37);
            this.bClear.TabIndex = 21;
            this.bClear.Text = "C";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bNum0
            // 
            this.bNum0.BackColor = System.Drawing.Color.Yellow;
            this.bNum0.Location = new System.Drawing.Point(60, 223);
            this.bNum0.Name = "bNum0";
            this.bNum0.Size = new System.Drawing.Size(40, 37);
            this.bNum0.TabIndex = 22;
            this.bNum0.Text = "0";
            this.bNum0.UseVisualStyleBackColor = false;
            this.bNum0.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bPoint
            // 
            this.bPoint.BackColor = System.Drawing.Color.Yellow;
            this.bPoint.Location = new System.Drawing.Point(104, 223);
            this.bPoint.Name = "bPoint";
            this.bPoint.Size = new System.Drawing.Size(40, 37);
            this.bPoint.TabIndex = 23;
            this.bPoint.Text = ",";
            this.bPoint.UseVisualStyleBackColor = false;
            this.bPoint.Click += new System.EventHandler(this.bPoint_Click);
            // 
            // bPlus
            // 
            this.bPlus.BackColor = System.Drawing.Color.Yellow;
            this.bPlus.Location = new System.Drawing.Point(150, 94);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(40, 37);
            this.bPlus.TabIndex = 24;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = false;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bMinus
            // 
            this.bMinus.BackColor = System.Drawing.Color.Yellow;
            this.bMinus.Location = new System.Drawing.Point(150, 137);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(40, 37);
            this.bMinus.TabIndex = 25;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = false;
            this.bMinus.Click += new System.EventHandler(this.bMinus_Click);
            // 
            // bRavno
            // 
            this.bRavno.BackColor = System.Drawing.Color.Yellow;
            this.bRavno.Location = new System.Drawing.Point(196, 94);
            this.bRavno.Name = "bRavno";
            this.bRavno.Size = new System.Drawing.Size(40, 166);
            this.bRavno.TabIndex = 26;
            this.bRavno.Text = "=";
            this.bRavno.UseVisualStyleBackColor = false;
            this.bRavno.Click += new System.EventHandler(this.bRavno_Click);
            // 
            // bUmn
            // 
            this.bUmn.BackColor = System.Drawing.Color.Yellow;
            this.bUmn.Location = new System.Drawing.Point(150, 179);
            this.bUmn.Name = "bUmn";
            this.bUmn.Size = new System.Drawing.Size(40, 37);
            this.bUmn.TabIndex = 27;
            this.bUmn.Text = "*";
            this.bUmn.UseVisualStyleBackColor = false;
            this.bUmn.Click += new System.EventHandler(this.bUmn_Click);
            // 
            // bDelenie
            // 
            this.bDelenie.BackColor = System.Drawing.Color.Yellow;
            this.bDelenie.Location = new System.Drawing.Point(150, 223);
            this.bDelenie.Name = "bDelenie";
            this.bDelenie.Size = new System.Drawing.Size(40, 37);
            this.bDelenie.TabIndex = 28;
            this.bDelenie.Text = "/";
            this.bDelenie.UseVisualStyleBackColor = false;
            this.bDelenie.Click += new System.EventHandler(this.bDelenie_Click);
            // 
            // tb_Calc
            // 
            this.tb_Calc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Calc.BackColor = System.Drawing.Color.Red;
            this.tb_Calc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_Calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Calc.Location = new System.Drawing.Point(14, 29);
            this.tb_Calc.Name = "tb_Calc";
            this.tb_Calc.Size = new System.Drawing.Size(324, 29);
            this.tb_Calc.TabIndex = 29;
            this.tb_Calc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Calc_KeyPress);
            // 
            // Anim
            // 
            this.Anim.Enabled = true;
            this.Anim.Interval = 150;
            this.Anim.Tick += new System.EventHandler(this.Anim_Tick);
            // 
            // fCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(342, 308);
            this.Controls.Add(this.bTg);
            this.Controls.Add(this.bsin);
            this.Controls.Add(this.bCos);
            this.Controls.Add(this.tb_Calc);
            this.Controls.Add(this.bDelenie);
            this.Controls.Add(this.bUmn);
            this.Controls.Add(this.bRavno);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.bSqrt);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.bX_in2);
            this.Controls.Add(this.bPoint);
            this.Controls.Add(this.bNum0);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bNum9);
            this.Controls.Add(this.bNum7);
            this.Controls.Add(this.bNum8);
            this.Controls.Add(this.bNum6);
            this.Controls.Add(this.bNum5);
            this.Controls.Add(this.bNum3);
            this.Controls.Add(this.bNum2);
            this.Controls.Add(this.bNum4);
            this.Controls.Add(this.bNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.fCalc_Load);
            this.LocationChanged += new System.EventHandler(this.fCalc_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bsin;
        private System.Windows.Forms.Button bCos;
        private System.Windows.Forms.Button bTg;
        private System.Windows.Forms.Button bSqrt;
        private System.Windows.Forms.Button bX_in2;
        private System.Windows.Forms.Button bNum1;
        private System.Windows.Forms.Button bNum4;
        private System.Windows.Forms.Button bNum2;
        private System.Windows.Forms.Button bNum3;
        private System.Windows.Forms.Button bNum5;
        private System.Windows.Forms.Button bNum6;
        private System.Windows.Forms.Button bNum8;
        private System.Windows.Forms.Button bNum7;
        private System.Windows.Forms.Button bNum9;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bNum0;
        private System.Windows.Forms.Button bPoint;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bRavno;
        private System.Windows.Forms.Button bUmn;
        private System.Windows.Forms.Button bDelenie;
        private System.Windows.Forms.TextBox tb_Calc;
        private System.Windows.Forms.Timer Anim;
    }
}

