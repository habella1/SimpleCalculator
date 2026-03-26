namespace SimpleCalculator
{
    partial class Form1
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
            lbTitle = new Label();
            txtExpression = new TextBox();
            txtResult = new TextBox();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnDiv = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMul = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMinus = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEquals = new Button();
            btnEnter = new Button();
            btnRandomColor = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("한컴 백제 B", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbTitle.ForeColor = Color.DarkCyan;
            lbTitle.Location = new Point(24, 17);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(518, 71);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Simple Calculator";
            // 
            // txtExpression
            // 
            txtExpression.Location = new Point(88, 118);
            txtExpression.Name = "txtExpression";
            txtExpression.Size = new Size(610, 39);
            txtExpression.TabIndex = 1;
            txtExpression.TextChanged += txtExpression_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(88, 190);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(610, 39);
            txtResult.TabIndex = 2;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Font = new Font("Arial Rounded MT Bold", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearEntry.Location = new Point(88, 286);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(127, 67);
            btnClearEntry.TabIndex = 3;
            btnClearEntry.Text = "ＣＥ";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Rounded MT Bold", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(256, 286);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 67);
            btnClear.TabIndex = 4;
            btnClear.Text = "Ｃ";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(415, 286);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 67);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "ｄｅｌ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Arial Rounded MT Bold", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(571, 286);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(127, 67);
            btnDiv.TabIndex = 6;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click_1;
            // 
            // btn7
            // 
            btn7.Location = new Point(88, 391);
            btn7.Name = "btn7";
            btn7.Size = new Size(127, 67);
            btn7.TabIndex = 7;
            btn7.Text = "７";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(256, 391);
            btn8.Name = "btn8";
            btn8.Size = new Size(127, 67);
            btn8.TabIndex = 8;
            btn8.Text = "８";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(415, 391);
            btn9.Name = "btn9";
            btn9.Size = new Size(127, 67);
            btn9.TabIndex = 9;
            btn9.Text = "９";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(571, 391);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(127, 67);
            btnMul.TabIndex = 10;
            btnMul.Text = "Ｘ";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(88, 499);
            btn4.Name = "btn4";
            btn4.Size = new Size(127, 67);
            btn4.TabIndex = 11;
            btn4.Text = "４";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(256, 499);
            btn5.Name = "btn5";
            btn5.Size = new Size(127, 67);
            btn5.TabIndex = 12;
            btn5.Text = "５";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(415, 499);
            btn6.Name = "btn6";
            btn6.Size = new Size(127, 67);
            btn6.TabIndex = 13;
            btn6.Text = "６";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(571, 499);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(127, 67);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "－";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnSub_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(88, 608);
            btn1.Name = "btn1";
            btn1.Size = new Size(127, 67);
            btn1.TabIndex = 15;
            btn1.Text = "１";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(256, 608);
            btn2.Name = "btn2";
            btn2.Size = new Size(127, 67);
            btn2.TabIndex = 16;
            btn2.Text = "２";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(415, 608);
            btn3.Name = "btn3";
            btn3.Size = new Size(127, 67);
            btn3.TabIndex = 17;
            btn3.Text = "３";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(571, 608);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(127, 67);
            btnPlus.TabIndex = 18;
            btnPlus.Text = "＋";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(88, 715);
            btn0.Name = "btn0";
            btn0.Size = new Size(127, 67);
            btn0.TabIndex = 19;
            btn0.Text = "＋／－";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click_1;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(256, 715);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(127, 67);
            btnDot.TabIndex = 20;
            btnDot.Text = "０";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(415, 715);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(127, 67);
            btnEquals.TabIndex = 21;
            btnEquals.Text = "．";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(571, 715);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(127, 67);
            btnEnter.TabIndex = 22;
            btnEnter.Text = "＝";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnRandomColor
            // 
            btnRandomColor.BackColor = Color.FromArgb(255, 192, 192);
            btnRandomColor.Font = new Font("한컴 백제 M", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnRandomColor.ForeColor = Color.FromArgb(192, 0, 192);
            btnRandomColor.Location = new Point(633, 17);
            btnRandomColor.Name = "btnRandomColor";
            btnRandomColor.Size = new Size(146, 49);
            btnRandomColor.TabIndex = 23;
            btnRandomColor.Text = "색상변경";
            btnRandomColor.UseVisualStyleBackColor = false;
            btnRandomColor.Click += btnRandomColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 829);
            Controls.Add(btnRandomColor);
            Controls.Add(btnEnter);
            Controls.Add(btnEquals);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnPlus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMinus);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMul);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDiv);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnClearEntry);
            Controls.Add(txtResult);
            Controls.Add(txtExpression);
            Controls.Add(lbTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private TextBox txtExpression;
        private TextBox txtResult;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnDelete;
        private Button btnDiv;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMul;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMinus;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button btn0;
        private Button btnDot;
        private Button btnEquals;
        private Button btnEnter;
        private Button btnRandomColor;
    }
}
