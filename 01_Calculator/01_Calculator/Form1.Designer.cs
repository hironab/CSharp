﻿namespace _01_Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label1.Location = new Point(28, 56);
            label1.Name = "label1";
            label1.Size = new Size(84, 45);
            label1.TabIndex = 0;
            label1.Text = "単価";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label2.Location = new Point(28, 134);
            label2.Name = "label2";
            label2.Size = new Size(84, 45);
            label2.TabIndex = 1;
            label2.Text = "数量";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label3.Location = new Point(510, 56);
            label3.Name = "label3";
            label3.Size = new Size(173, 45);
            label3.TabIndex = 2;
            label3.Text = "税抜き価格";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label4.Location = new Point(510, 134);
            label4.Name = "label4";
            label4.Size = new Size(116, 45);
            label4.TabIndex = 3;
            label4.Text = "消費税";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label5.Location = new Point(510, 222);
            label5.Name = "label5";
            label5.Size = new Size(84, 45);
            label5.TabIndex = 4;
            label5.Text = "合計";
            // 
            // label6
            // 
            label6.Location = new Point(727, 56);
            label6.Name = "label6";
            label6.Size = new Size(200, 40);
            label6.TabIndex = 5;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.Location = new Point(727, 144);
            label7.Name = "label7";
            label7.Size = new Size(200, 40);
            label7.TabIndex = 6;
            label7.Text = "label7";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.Location = new Point(727, 222);
            label8.Name = "label8";
            label8.Size = new Size(200, 40);
            label8.TabIndex = 7;
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            button1.Location = new Point(131, 225);
            button1.Name = "button1";
            button1.Size = new Size(200, 46);
            button1.TabIndex = 10;
            button1.Text = "計算実行";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 403);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
