using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int num1 = 0;
        int num2 = 0;
        string op = "";

        public Form1()
        {
            InitializeComponent();
        }

        // 숫자 버튼들
        private void btn0_Click(object sender, EventArgs e) { txtResult.Text += "0"; }
        private void btn1_Click(object sender, EventArgs e) { txtResult.Text += "1"; }
        private void btn2_Click(object sender, EventArgs e) { txtResult.Text += "2"; }
        private void btn3_Click(object sender, EventArgs e) { txtResult.Text += "3"; }
        private void btn4_Click(object sender, EventArgs e) { txtResult.Text += "4"; }
        private void btn5_Click(object sender, EventArgs e) { txtResult.Text += "5"; }
        private void btn6_Click(object sender, EventArgs e) { txtResult.Text += "6"; }
        private void btn7_Click(object sender, EventArgs e) { txtResult.Text += "7"; }
        private void btn8_Click(object sender, EventArgs e) { txtResult.Text += "8"; }
        private void btn9_Click(object sender, EventArgs e) { txtResult.Text += "9"; }

        // 더하기
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") return;

            num1 = int.Parse(txtResult.Text);
            op = "+";

            txtExpression.Text = txtResult.Text + " +";
            txtResult.Text = "";
        }

        // 결과
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") return;

            num2 = int.Parse(txtResult.Text);

            int result = 0;

            if (op == "+")
                result = num1 + num2;

            txtResult.Text = result.ToString();
            txtExpression.Text = "";
        }

        // ===== Designer 연결 맞추기용 (비워둠) =====

        private void btnSub_Click(object sender, EventArgs e) { }
        private void btnMul_Click(object sender, EventArgs e) { }
        private void btnDiv_Click(object sender, EventArgs e) { }

        private void btnClear_Click(object sender, EventArgs e) { }
        private void btnClearEntry_Click(object sender, EventArgs e) { }
        private void btnDelete_Click(object sender, EventArgs e) { }

        private void btnDot_Click(object sender, EventArgs e) { }

        private void btnEquals_Click(object sender, EventArgs e) { }

        private void btnSign_Click(object sender, EventArgs e) { }

        private void btn0_Click_1(object sender, EventArgs e) { }
    }
}