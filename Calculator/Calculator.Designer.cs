namespace Calculator
{
    partial class Calculator
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
            Result_txt = new TextBox();
            label1 = new Label();
            btn_c = new Button();
            btn_percentage = new Button();
            btn_result = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_div = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_mul = new Button();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_subs = new Button();
            btn_0 = new Button();
            btn_float = new Button();
            btn_add = new Button();
            buttonp = new Panel();
            btn_00 = new Button();
            buttonp.SuspendLayout();
            SuspendLayout();
            // 
            // Result_txt
            // 
            Result_txt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Result_txt.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Result_txt.Location = new Point(12, 71);
            Result_txt.Name = "Result_txt";
            Result_txt.Size = new Size(342, 39);
            Result_txt.TabIndex = 3;
            Result_txt.TextAlign = HorizontalAlignment.Right;
            Result_txt.TextChanged += Result_txt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 43);
            label1.Name = "label1";
            label1.Size = new Size(0, 22);
            label1.TabIndex = 4;
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // btn_c
            // 
            btn_c.BackColor = Color.CadetBlue;
            btn_c.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_c.ForeColor = Color.Red;
            btn_c.Location = new Point(13, 13);
            btn_c.Name = "btn_c";
            btn_c.Size = new Size(75, 40);
            btn_c.TabIndex = 0;
            btn_c.Text = "C";
            btn_c.UseVisualStyleBackColor = false;
            btn_c.Click += btn_c_Click;
            // 
            // btn_percentage
            // 
            btn_percentage.BackColor = Color.CadetBlue;
            btn_percentage.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_percentage.ForeColor = Color.Lime;
            btn_percentage.Location = new Point(94, 13);
            btn_percentage.Name = "btn_percentage";
            btn_percentage.Size = new Size(75, 40);
            btn_percentage.TabIndex = 2;
            btn_percentage.Text = "%";
            btn_percentage.UseVisualStyleBackColor = false;
            btn_percentage.Click += btn_percentage_Click;
            // 
            // btn_result
            // 
            btn_result.BackColor = Color.DarkCyan;
            btn_result.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_result.ForeColor = SystemColors.Info;
            btn_result.Location = new Point(254, 151);
            btn_result.Name = "btn_result";
            btn_result.Size = new Size(75, 86);
            btn_result.TabIndex = 3;
            btn_result.Text = "=";
            btn_result.UseVisualStyleBackColor = false;
            btn_result.Click += btn_result_Click;
            // 
            // btn_7
            // 
            btn_7.BackColor = Color.CadetBlue;
            btn_7.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_7.ForeColor = SystemColors.ButtonHighlight;
            btn_7.Location = new Point(13, 59);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(75, 40);
            btn_7.TabIndex = 4;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += btn_7_Click;
            // 
            // btn_8
            // 
            btn_8.BackColor = Color.CadetBlue;
            btn_8.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_8.ForeColor = SystemColors.ButtonHighlight;
            btn_8.Location = new Point(94, 59);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(75, 40);
            btn_8.TabIndex = 5;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += btn_8_Click;
            // 
            // btn_9
            // 
            btn_9.BackColor = Color.CadetBlue;
            btn_9.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_9.ForeColor = SystemColors.ButtonHighlight;
            btn_9.Location = new Point(175, 59);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(75, 40);
            btn_9.TabIndex = 6;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = false;
            btn_9.Click += btn_9_Click;
            // 
            // btn_div
            // 
            btn_div.BackColor = Color.CadetBlue;
            btn_div.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_div.ForeColor = Color.Lime;
            btn_div.Location = new Point(175, 13);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(75, 40);
            btn_div.TabIndex = 7;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = false;
            btn_div.Click += btn_div_Click;
            // 
            // btn_4
            // 
            btn_4.BackColor = Color.CadetBlue;
            btn_4.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_4.ForeColor = SystemColors.ButtonHighlight;
            btn_4.Location = new Point(13, 105);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(75, 40);
            btn_4.TabIndex = 8;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += btn_4_Click;
            // 
            // btn_5
            // 
            btn_5.BackColor = Color.CadetBlue;
            btn_5.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_5.ForeColor = SystemColors.ButtonHighlight;
            btn_5.Location = new Point(94, 105);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(75, 40);
            btn_5.TabIndex = 9;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += btn_5_Click_1;
            // 
            // btn_6
            // 
            btn_6.BackColor = Color.CadetBlue;
            btn_6.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_6.ForeColor = SystemColors.ButtonHighlight;
            btn_6.Location = new Point(175, 105);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(75, 40);
            btn_6.TabIndex = 10;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += button11_Click;
            // 
            // btn_mul
            // 
            btn_mul.BackColor = Color.CadetBlue;
            btn_mul.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_mul.ForeColor = Color.Lime;
            btn_mul.Location = new Point(254, 105);
            btn_mul.Name = "btn_mul";
            btn_mul.Size = new Size(75, 40);
            btn_mul.TabIndex = 11;
            btn_mul.Text = "X";
            btn_mul.UseVisualStyleBackColor = false;
            btn_mul.Click += btn_mul_Click;
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.CadetBlue;
            btn_1.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_1.ForeColor = SystemColors.ButtonHighlight;
            btn_1.Location = new Point(13, 151);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(75, 40);
            btn_1.TabIndex = 12;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += btn_1_Click_1;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.CadetBlue;
            btn_2.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_2.ForeColor = SystemColors.ButtonHighlight;
            btn_2.Location = new Point(94, 151);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(75, 40);
            btn_2.TabIndex = 13;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += btn_2_Click;
            // 
            // btn_3
            // 
            btn_3.BackColor = Color.CadetBlue;
            btn_3.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_3.ForeColor = SystemColors.ButtonHighlight;
            btn_3.Location = new Point(175, 151);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(75, 40);
            btn_3.TabIndex = 14;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += btn_3_Click;
            // 
            // btn_subs
            // 
            btn_subs.BackColor = Color.CadetBlue;
            btn_subs.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_subs.ForeColor = Color.Lime;
            btn_subs.Location = new Point(254, 59);
            btn_subs.Name = "btn_subs";
            btn_subs.Size = new Size(75, 40);
            btn_subs.TabIndex = 15;
            btn_subs.Text = "-";
            btn_subs.UseVisualStyleBackColor = false;
            btn_subs.Click += button16_Click;
            // 
            // btn_0
            // 
            btn_0.BackColor = Color.CadetBlue;
            btn_0.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_0.ForeColor = SystemColors.ButtonHighlight;
            btn_0.Location = new Point(13, 197);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(75, 40);
            btn_0.TabIndex = 17;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = false;
            btn_0.Click += button18_Click;
            // 
            // btn_float
            // 
            btn_float.BackColor = Color.CadetBlue;
            btn_float.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_float.ForeColor = SystemColors.ButtonHighlight;
            btn_float.Location = new Point(175, 197);
            btn_float.Name = "btn_float";
            btn_float.Size = new Size(75, 40);
            btn_float.TabIndex = 18;
            btn_float.Text = "000";
            btn_float.UseVisualStyleBackColor = false;
            btn_float.Click += button19_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.CadetBlue;
            btn_add.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_add.ForeColor = Color.Lime;
            btn_add.Location = new Point(254, 13);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 40);
            btn_add.TabIndex = 19;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // buttonp
            // 
            buttonp.Controls.Add(btn_00);
            buttonp.Controls.Add(btn_add);
            buttonp.Controls.Add(btn_float);
            buttonp.Controls.Add(btn_0);
            buttonp.Controls.Add(btn_result);
            buttonp.Controls.Add(btn_c);
            buttonp.Controls.Add(btn_subs);
            buttonp.Controls.Add(btn_3);
            buttonp.Controls.Add(btn_2);
            buttonp.Controls.Add(btn_1);
            buttonp.Controls.Add(btn_mul);
            buttonp.Controls.Add(btn_6);
            buttonp.Controls.Add(btn_5);
            buttonp.Controls.Add(btn_4);
            buttonp.Controls.Add(btn_div);
            buttonp.Controls.Add(btn_9);
            buttonp.Controls.Add(btn_8);
            buttonp.Controls.Add(btn_7);
            buttonp.Controls.Add(btn_percentage);
            buttonp.Location = new Point(12, 124);
            buttonp.Name = "buttonp";
            buttonp.Size = new Size(342, 251);
            buttonp.TabIndex = 1;
            buttonp.Paint += panel2_Paint;
            // 
            // btn_00
            // 
            btn_00.BackColor = Color.CadetBlue;
            btn_00.Font = new Font("Consolas", 18F, FontStyle.Bold);
            btn_00.ForeColor = SystemColors.ControlLightLight;
            btn_00.Location = new Point(94, 197);
            btn_00.Name = "btn_00";
            btn_00.Size = new Size(75, 40);
            btn_00.TabIndex = 21;
            btn_00.Text = "00";
            btn_00.UseVisualStyleBackColor = false;
            btn_00.Click += btn_00_Click_2;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(367, 384);
            Controls.Add(label1);
            Controls.Add(Result_txt);
            Controls.Add(buttonp);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            buttonp.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Result_txt;
        private Label label1;
        private Button btn_c;
        private Button btn_percentage;
        private Button btn_result;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_div;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_mul;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_subs;
        private Button btn_0;
        private Button btn_float;
        private Button btn_add;
        private Panel buttonp;
        private Button btn_00;
    }
}