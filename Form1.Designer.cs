namespace myCalc
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button18 = new Button();
            button17 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.DarkTurquoise;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(279, 172);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(67, 63);
            button1.TabIndex = 0;
            button1.Text = "/";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(30, 31);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(315, 81);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.DarkTurquoise;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(279, 243);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(67, 63);
            button2.TabIndex = 2;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.BackColor = Color.DarkTurquoise;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(279, 315);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(67, 63);
            button3.TabIndex = 3;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.BackColor = Color.DarkTurquoise;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(279, 385);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(67, 63);
            button4.TabIndex = 4;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.BackColor = Color.Coral;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(197, 385);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(67, 63);
            button5.TabIndex = 5;
            button5.Text = "=";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top;
            button6.BackColor = SystemColors.ButtonShadow;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(197, 315);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(67, 63);
            button6.TabIndex = 6;
            button6.Text = "3";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button13_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top;
            button7.BackColor = SystemColors.ButtonShadow;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(197, 243);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(67, 63);
            button7.TabIndex = 7;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button13_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top;
            button8.BackColor = SystemColors.ButtonShadow;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(197, 172);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(67, 63);
            button8.TabIndex = 8;
            button8.Text = "9";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button13_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top;
            button9.BackColor = SystemColors.ButtonShadow;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(112, 172);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(67, 63);
            button9.TabIndex = 9;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button13_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top;
            button10.BackColor = SystemColors.ButtonShadow;
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(112, 243);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(67, 63);
            button10.TabIndex = 10;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button13_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Top;
            button11.BackColor = SystemColors.ButtonShadow;
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(112, 315);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(67, 63);
            button11.TabIndex = 11;
            button11.Text = "2";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button13_Click;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Top;
            button12.BackColor = SystemColors.ButtonShadow;
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(112, 385);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new Size(67, 63);
            button12.TabIndex = 12;
            button12.Text = ",";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.Top;
            button13.BackColor = SystemColors.ButtonShadow;
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(30, 172);
            button13.Margin = new Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Size = new Size(67, 63);
            button13.TabIndex = 13;
            button13.Text = "7";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Anchor = AnchorStyles.Top;
            button14.BackColor = SystemColors.ButtonShadow;
            button14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(30, 243);
            button14.Margin = new Padding(3, 4, 3, 4);
            button14.Name = "button14";
            button14.Size = new Size(67, 63);
            button14.TabIndex = 14;
            button14.Text = "4";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button13_Click;
            // 
            // button15
            // 
            button15.Anchor = AnchorStyles.Top;
            button15.BackColor = SystemColors.ButtonShadow;
            button15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(30, 315);
            button15.Margin = new Padding(3, 4, 3, 4);
            button15.Name = "button15";
            button15.Size = new Size(67, 63);
            button15.TabIndex = 15;
            button15.Text = "1";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button13_Click;
            // 
            // button16
            // 
            button16.Anchor = AnchorStyles.Top;
            button16.BackColor = SystemColors.ButtonShadow;
            button16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(30, 385);
            button16.Margin = new Padding(3, 4, 3, 4);
            button16.Name = "button16";
            button16.Size = new Size(67, 63);
            button16.TabIndex = 16;
            button16.Text = "0";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button13_Click;
            // 
            // button18
            // 
            button18.Anchor = AnchorStyles.Top;
            button18.BackColor = Color.Coral;
            button18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button18.Location = new Point(197, 127);
            button18.Margin = new Padding(3, 4, 3, 4);
            button18.Name = "button18";
            button18.Size = new Size(149, 41);
            button18.TabIndex = 18;
            button18.Text = "+/-";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button17
            // 
            button17.Anchor = AnchorStyles.Top;
            button17.AutoSize = true;
            button17.BackColor = Color.Coral;
            button17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Location = new Point(30, 127);
            button17.Margin = new Padding(3, 4, 3, 4);
            button17.Name = "button17";
            button17.Size = new Size(150, 41);
            button17.TabIndex = 19;
            button17.Text = "C";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(376, 485);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "myCalc";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button button1;
        private TextBox textBox1;
        private Button button17;
        private Button button18;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}