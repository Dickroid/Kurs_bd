﻿namespace Dbkurs
{
    partial class FormCONST
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
            this.label1 = new System.Windows.Forms.Label();
            this.tch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Rc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ws = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите время работы tч";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tch
            // 
            this.tch.Location = new System.Drawing.Point(10, 41);
            this.tch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tch.Name = "tch";
            this.tch.Size = new System.Drawing.Size(116, 20);
            this.tch.TabIndex = 1;
            this.tch.TextChanged += new System.EventHandler(this.tch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите количество роликов (1 или 2)";
            // 
            // Rc
            // 
            this.Rc.Location = new System.Drawing.Point(11, 100);
            this.Rc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rc.Name = "Rc";
            this.Rc.Size = new System.Drawing.Size(116, 20);
            this.Rc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Число смен работы передачи в сутки (2 или 3)";
            // 
            // Ws
            // 
            this.Ws.Location = new System.Drawing.Point(11, 158);
            this.Ws.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ws.Name = "Ws";
            this.Ws.Size = new System.Drawing.Size(116, 20);
            this.Ws.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 433);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 93);
            this.button1.TabIndex = 6;
            this.button1.Text = "РАСЧЁТ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Расчетная прочность зубьев  ремня Sigma Cd";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Допускаемое напряжение на зубья ремня sigma cd p";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(758, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 10;
            // 
            // FormCONST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 557);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ws);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tch);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCONST";
            this.Text = "FormCONST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ws;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}