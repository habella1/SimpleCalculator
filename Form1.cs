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

        // + 
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") return;
            num1 = int.Parse(txtResult.Text);
            op = "+";
            txtExpression.Text = txtResult.Text + " +";
            txtResult.Text = "";
        }

        // -
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") return;
            num1 = int.Parse(txtResult.Text);
            op = "-";
            txtExpression.Text = txtResult.Text + " -";
            txtResult.Text = "";
        }

        // *
        private void btnMul_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") return;
            num1 = int.Parse(txtResult.Text);
            op = "*";
            txtExpression.Text = txtResult.Text + " *";
            txtResult.Text = "";
        }

        // /
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") return;
            num1 = int.Parse(txtResult.Text);
            op = "/";
            txtExpression.Text = txtResult.Text + " /";
            txtResult.Text = "";
        }

        // =
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") return;

            num2 = int.Parse(txtResult.Text);
            int result = 0;

            if (op == "+") result = num1 + num2;
            else if (op == "-") result = num1 - num2;
            else if (op == "*") result = num1 * num2;
            else if (op == "/")
            {
                if (num2 == 0)
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.");
                    return;
                }
                result = num1 / num2;
            }

            txtResult.Text = result.ToString();
            txtExpression.Text = "";
        }

        // ===== 과제3용 버튼들  =====
        private void btnClear_Click(object sender, EventArgs e) {
            txtResult.Text = "";       // 입력창 초기화
            txtExpression.Text = "";   // 연산 표시 초기화
            num1 = 0;
            num2 = 0;
            op = "";

        }
        private void btnClearEntry_Click(object sender, EventArgs e) {
            txtResult.Text = "";
        }
        private void btnDelete_Click(object sender, EventArgs e) {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }

        }
        private void btnDot_Click(object sender, EventArgs e) { }
        private void btnEquals_Click(object sender, EventArgs e) { }
        private void btnSign_Click(object sender, EventArgs e) { }
        private void btn0_Click_1(object sender, EventArgs e) { }

        private void btnDiv_Click_1(object sender, EventArgs e)
        {
            if (txtResult.Text == "") return;     // 숫자가 없으면 아무 작업 안 함
            num1 = int.Parse(txtResult.Text);     // 첫 번째 숫자 저장
            op = "/";                              // 연산자 저장
            txtExpression.Text = txtResult.Text + " ÷"; // 위쪽 표시 업데이트
            txtResult.Text = "";                   // 입력창 초기화
        }
    }
}
