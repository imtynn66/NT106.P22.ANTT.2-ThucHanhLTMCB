﻿namespace Lab1
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
            textNum1 = new TextBox();
            textNum2 = new TextBox();
            textSum = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSum = new Button();
            btnDel = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 70);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 4;
            label1.Text = "Số thứ 1";
            label1.Click += label1_Click;
            // 
            // textNum1
            // 
            textNum1.Location = new Point(313, 70);
            textNum1.Margin = new Padding(3, 2, 3, 2);
            textNum1.Name = "textNum1";
            textNum1.Size = new Size(173, 23);
            textNum1.TabIndex = 1;
            textNum1.TextChanged += iNum1_TextChanged;
            // 
            // textNum2
            // 
            textNum2.Location = new Point(313, 115);
            textNum2.Margin = new Padding(3, 2, 3, 2);
            textNum2.Name = "textNum2";
            textNum2.Size = new Size(173, 23);
            textNum2.TabIndex = 2;
            // 
            // textSum
            // 
            textSum.Location = new Point(313, 158);
            textSum.Margin = new Padding(3, 2, 3, 2);
            textSum.Name = "textSum";
            textSum.Size = new Size(173, 23);
            textSum.TabIndex = 3;
            textSum.BindingContextChanged += S;
            textSum.TextChanged += iSum_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 115);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Số thứ 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 158);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Kết quả";
            // 
            // btnSum
            // 
            btnSum.Location = new Point(203, 226);
            btnSum.Margin = new Padding(3, 2, 3, 2);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(82, 22);
            btnSum.TabIndex = 7;
            btnSum.Text = "Tính tổng";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += Sum_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(313, 226);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(82, 22);
            btnDel.TabIndex = 8;
            btnDel.Text = "Xoá";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(422, 226);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 9;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnExit);
            Controls.Add(btnDel);
            Controls.Add(btnSum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSum);
            Controls.Add(textNum2);
            Controls.Add(textNum1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Bai1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNum1;
        private TextBox textNum2;
        private TextBox textSum;
        private Label label2;
        private Label label3;
        private Button btnSum;
        private Button btnDel;
        private Button btnExit;
    }
}
