﻿namespace PLibrary
{
    partial class CheckOut
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
            this.SelectAcc = new System.Windows.Forms.ComboBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Process = new System.Windows.Forms.Button();
            this.SelectBook = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an Account";
            // 
            // SelectAcc
            // 
            this.SelectAcc.FormattingEnabled = true;
            this.SelectAcc.Location = new System.Drawing.Point(174, 28);
            this.SelectAcc.Margin = new System.Windows.Forms.Padding(2);
            this.SelectAcc.Name = "SelectAcc";
            this.SelectAcc.Size = new System.Drawing.Size(163, 21);
            this.SelectAcc.TabIndex = 1;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(90, 80);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(88, 45);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // btn_End
            // 
            this.btn_End.Location = new System.Drawing.Point(225, 79);
            this.btn_End.Margin = new System.Windows.Forms.Padding(2);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(86, 46);
            this.btn_End.TabIndex = 3;
            this.btn_End.Text = "End";
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Click += new System.EventHandler(this.Btn_End_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Book ID";
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(162, 185);
            this.btn_Process.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(90, 51);
            this.btn_Process.TabIndex = 6;
            this.btn_Process.Text = "Process";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.Btn_Process_Click);
            // 
            // SelectBook
            // 
            this.SelectBook.FormattingEnabled = true;
            this.SelectBook.Location = new System.Drawing.Point(101, 138);
            this.SelectBook.Margin = new System.Windows.Forms.Padding(2);
            this.SelectBook.Name = "SelectBook";
            this.SelectBook.Size = new System.Drawing.Size(273, 21);
            this.SelectBook.TabIndex = 7;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 247);
            this.Controls.Add(this.SelectBook);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.SelectAcc);
            this.Controls.Add(this.label1);
            this.Name = "CheckOut";
            this.Text = "Check Out";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectAcc;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.ComboBox SelectBook;
    }
}