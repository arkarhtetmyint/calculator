
namespace Calculator
{
    partial class frmCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalc));
            this.btn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResultShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(31, 89);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 45);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "7";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "8";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.operator_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Location = new System.Drawing.Point(235, 89);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(45, 45);
            this.btnClearEntry.TabIndex = 4;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(235, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 45);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(184, 140);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 8;
            this.button6.Text = "*";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.operator_click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(133, 140);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 45);
            this.button7.TabIndex = 7;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(82, 140);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 6;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(31, 140);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 45);
            this.button9.TabIndex = 5;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(184, 191);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(45, 45);
            this.button11.TabIndex = 13;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.operator_click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(133, 191);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(45, 45);
            this.button12.TabIndex = 12;
            this.button12.Text = "3";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(82, 191);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(45, 45);
            this.button13.TabIndex = 11;
            this.button13.Text = "2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(31, 191);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(45, 45);
            this.button14.TabIndex = 10;
            this.button14.Text = "1";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(235, 191);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(45, 96);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(184, 242);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(45, 45);
            this.button16.TabIndex = 18;
            this.button16.Text = "+";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.operator_click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(133, 242);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(45, 45);
            this.button17.TabIndex = 17;
            this.button17.Text = ".";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button_click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(31, 242);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(96, 45);
            this.button19.TabIndex = 15;
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button_click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(31, 56);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(249, 27);
            this.txtResult.TabIndex = 20;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResultShow
            // 
            this.lblResultShow.AutoSize = true;
            this.lblResultShow.BackColor = System.Drawing.Color.White;
            this.lblResultShow.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultShow.Location = new System.Drawing.Point(31, 9);
            this.lblResultShow.Name = "lblResultShow";
            this.lblResultShow.Size = new System.Drawing.Size(0, 31);
            this.lblResultShow.TabIndex = 21;
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 309);
            this.Controls.Add(this.lblResultShow);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalc";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResultShow;
    }
}

