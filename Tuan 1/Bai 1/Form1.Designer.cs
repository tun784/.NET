namespace Bai_1
{
    partial class MainForm
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
            this._a = new System.Windows.Forms.Label();
            this._b = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this._result = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _a
            // 
            this._a.AutoSize = true;
            this._a.Location = new System.Drawing.Point(9, 9);
            this._a.Name = "_a";
            this._a.Size = new System.Drawing.Size(23, 13);
            this._a.TabIndex = 0;
            this._a.Text = "A =";
            // 
            // _b
            // 
            this._b.AutoSize = true;
            this._b.Location = new System.Drawing.Point(173, 9);
            this._b.Name = "_b";
            this._b.Size = new System.Drawing.Size(23, 13);
            this._b.TabIndex = 3;
            this._b.Text = "B =";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(38, 6);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(130, 20);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "0";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(202, 6);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(130, 20);
            this.txtB.TabIndex = 2;
            this.txtB.Text = "0";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // _result
            // 
            this._result.AutoSize = true;
            this._result.Location = new System.Drawing.Point(9, 35);
            this._result.Name = "_result";
            this._result.Size = new System.Drawing.Size(46, 13);
            this._result.TabIndex = 4;
            this._result.Text = "Kết Quả";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(61, 32);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(271, 20);
            this.txtResult.TabIndex = 5;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(12, 58);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(95, 58);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(176, 58);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(257, 58);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 90);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this._result);
            this.Controls.Add(this._b);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this._a);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cộng Trừ Nhân Chia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _a;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label _b;
        private System.Windows.Forms.Label _result;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
    }
}

