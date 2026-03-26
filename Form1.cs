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
            // Operator buttons may not have Click wired in Designer; ensure they call the correct handlers
            btnMinus.Click += btnSub_Click;
            btnMul.Click += btnMul_Click;
            btnDiv.Click += btnDiv_Click;
        }

        //  숫자 버튼들 (0~9)

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        // ＋ 더하기
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") return;

            num1 = int.Parse(txtResult.Text);
            op = "+";

            txtExpression.Text = txtResult.Text + " +";
            txtResult.Text = "";
        }

        // － 빼기
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") return;

            num1 = int.Parse(txtResult.Text);
            op = "-";

            txtExpression.Text = txtResult.Text + " -";
            txtResult.Text = "";
        }

        // ｘ 곱하기
        private void btnMul_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") return;

            num1 = int.Parse(txtResult.Text);
            op = "*";

            txtExpression.Text = txtResult.Text + " *";
            txtResult.Text = "";
        }

        // ／ 나누기
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") return;

            num1 = int.Parse(txtResult.Text);
            op = "/";

            txtExpression.Text = txtResult.Text + " /";
            txtResult.Text = "";
        }

        // ＝　결과
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") return;

            num2 = int.Parse(txtResult.Text);

            int result = 0;

            if (op == "+")
                result = num1 + num2;
            else if (op == "-")
                result = num1 - num2;
            else if (op == "*")
                result = num1 * num2;
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

        // C (전체 초기화)
        private void btnClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            op = "";

            txtExpression.Text = "";
            txtResult.Text = "";
        }

        //  CE (현재 입력 초기화)
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        //  Del (한 글자 삭제)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
        }

        //  . (소수점)
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("."))
            {
                if (txtResult.Text == "")
                    txtResult.Text = "0";

                txtResult.Text += ".";
            }
        }

        // Designer가 btn0에 연결한 핸들러 이름(btn0_Click_1)
        // 실제 동작은 부호 변경(btnSign_Click)과 동일하게 처리
        private void btn0_Click_1(object sender, EventArgs e)
        {
            btnSign_Click(sender, e);
        }

        // Designer가 btnEquals에 연결한 핸들러 이름(btnEquals_Click)
        // 실제 동작은 소수점 입력(btnDot_Click)과 동일하게 처리
        private void btnEquals_Click(object sender, EventArgs e)
        {
            btnDot_Click(sender, e);
        }

        //  +/- (부호 변경)
        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                int num = int.Parse(txtResult.Text);
                num = -num;
                txtResult.Text = num.ToString();
            }
        }
    }
}
