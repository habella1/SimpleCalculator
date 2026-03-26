namespace SimpleCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();

            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();

            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // txtExpression
            this.txtExpression.Location = new System.Drawing.Point(12, 12);
            this.txtExpression.Size = new System.Drawing.Size(260, 21);

            // txtResult
            this.txtResult.Location = new System.Drawing.Point(12, 40);
            this.txtResult.Size = new System.Drawing.Size(260, 21);

            // 숫자 버튼들 (간단 배치)
            this.btn1.Location = new System.Drawing.Point(12, 80);
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);

            this.btn2.Location = new System.Drawing.Point(72, 80);
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);

            this.btn3.Location = new System.Drawing.Point(132, 80);
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);

            this.btn4.Location = new System.Drawing.Point(12, 120);
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);

            this.btn5.Location = new System.Drawing.Point(72, 120);
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);

            this.btn6.Location = new System.Drawing.Point(132, 120);
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);

            this.btn7.Location = new System.Drawing.Point(12, 160);
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);

            this.btn8.Location = new System.Drawing.Point(72, 160);
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);

            this.btn9.Location = new System.Drawing.Point(132, 160);
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);

            this.btn0.Location = new System.Drawing.Point(72, 200);
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);

            // + 버튼
            this.btnPlus.Location = new System.Drawing.Point(200, 80);
            this.btnPlus.Text = "+";
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);

            // = 버튼
            this.btnEnter.Location = new System.Drawing.Point(200, 120);
            this.btnEnter.Text = "=";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);

            // Form 설정
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtExpression);
            this.Controls.Add(this.txtResult);

            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);

            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEnter);

            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.TextBox txtResult;

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEnter;
    }
}
